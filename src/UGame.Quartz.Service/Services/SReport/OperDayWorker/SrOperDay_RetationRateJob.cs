using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using Xxyy.DAL;
using Xxyy.Quartz.Dal;

namespace Xxyy.Quartz.BLL.Services.BasicReport.OperDayWorker
{
    public class SrOperDay_RetationRateJob : BasicReportJobBase<SrOperDay_RetationRateJob>
    {
        private readonly S_user_dayMO _sUserDayMo = new();
        private readonly BasicReportContext _context;
        private readonly Dictionary<string, Sr_oper_dayEO> _dict;

        public SrOperDay_RetationRateJob(BasicReportContext context, Dictionary<string, Sr_oper_dayEO> dict)
        {
            this._context = context;
            this._dict = dict ?? throw new ArgumentNullException("dict不能为空！");
        }

        public override async Task Execute()
        {
            await HandleOperRetentionRate();
        }

        #region 统计运营商每天的留存率(1天，3天，7天，15天)
        /// <summary>
        /// 统计运营商每天的留存率(1天，3天，7天，15天)
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task HandleOperRetentionRate()
        {
            //var operatorId = context.OperatorId;
            //var startDate = _context.ReportDate.Date;
            //遍历指定日期startdate所有运营商的统计
            var days = new[] { 1, 3, 7, 15 };
            HashSet<string> regUserIds = null;
            IEnumerable<string> intersectUsers = null;
            foreach (var item in this._dict)
            {
                var srOperDayEo = this._dict[item.Key];
                var loginUserIds = await GetOperLoginUserIds(item.Key);
                if (null == loginUserIds || loginUserIds.Count == 0) continue;
                //1.1、3、7、15天留存率 （昨天登录的用户数/day注册的用户数）
                await SetRegRetentions(days,regUserIds,loginUserIds,item.Key,intersectUsers,srOperDayEo);
                await SetRetentions(days,regUserIds,loginUserIds,item.Key,intersectUsers,srOperDayEo);
            }
        }

        /// <summary>
        /// 设置新用户的留存率
        /// </summary>
        /// <param name="days"></param>
        /// <param name="newUserIds"></param>
        /// <param name="loginUserIds"></param>
        /// <param name="operatorId"></param>
        /// <param name="intersectUsers"></param>
        /// <param name="srOperDayEo"></param>
        /// <returns></returns>
        private async Task SetRetentions(int[] days, HashSet<string> newUserIds, HashSet<string> loginUserIds, string operatorId, IEnumerable<string> intersectUsers, Sr_oper_dayEO srOperDayEo)
        {
            var startDate = this._context.ReportDate.Date;
            foreach (var day in days)
            {
                newUserIds = await GetOperNewUserIds(operatorId, startDate.AddDays(-day));
                if (newUserIds == null || newUserIds.Count() == 0) continue;
                intersectUsers = loginUserIds.Intersect(newUserIds);
                switch (day)
                {
                    case 1:
                        srOperDayEo.RetentionD1 = intersectUsers.Count() / newUserIds.Count();
                        break;
                    case 3:
                        srOperDayEo.RetentionD3 = intersectUsers.Count() / newUserIds.Count();
                        break;
                    case 7:
                        srOperDayEo.RetentionD7 = intersectUsers.Count() / newUserIds.Count();
                        break;
                    case 15:
                        srOperDayEo.RetentionD15 = intersectUsers.Count() / newUserIds.Count();
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 设置注册留存率
        /// </summary>
        /// <param name="days"></param>
        /// <param name="regUserIds"></param>
        /// <param name="loginUserIds"></param>
        /// <param name="operatorId"></param>
        /// <param name="intersectUsers"></param>
        /// <param name="srOperDayEo"></param>
        /// <returns></returns>
        private async Task SetRegRetentions(int[] days, HashSet<string> regUserIds,HashSet<string> loginUserIds, string operatorId, IEnumerable<string> intersectUsers,Sr_oper_dayEO srOperDayEo)
        {
            var startDate = this._context.ReportDate.Date;
            foreach (var day in days)
            {
                regUserIds = await GetOperRegisterUserIds(operatorId, startDate.AddDays(-day));
                if (regUserIds == null || regUserIds.Count() == 0) continue;
                intersectUsers = loginUserIds.Intersect(regUserIds);
                switch (day)
                {
                    case 1:
                        srOperDayEo.RegRetentionD1 = intersectUsers.Count() / regUserIds.Count();
                        break;
                    case 3:
                        srOperDayEo.RegRetentionD3 = intersectUsers.Count() / regUserIds.Count();
                        break;
                    case 7:
                        srOperDayEo.RegRetentionD7 = intersectUsers.Count() / regUserIds.Count();
                        break;
                    case 15:
                        srOperDayEo.RegRetentionD15 = intersectUsers.Count() / regUserIds.Count();
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 获取昨天登录的用户ids数
        /// </summary>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        private async Task<HashSet<string>> GetOperLoginUserIds(string operatorId)
        {
            var startDate = this._context.ReportDate.Date;
            var pageCount = await _sUserDayMo.GetPageCountAsync(PAGESIZE, $"DayID=@DayID and UserKind=1 and OperatorID=@OperatorID",values:new object[] { startDate, operatorId });
            if (pageCount == 0) return null;
            //昨天登录的用户数
            var loginUsers = new HashSet<string>();
            List<S_user_dayEO> pageListUserDay = null;
            for (var page = 1; page <= pageCount; page++)
            {
                pageListUserDay = await _sUserDayMo.GetPagerListAsync(PAGESIZE, page, $"DayID=@DayID and UserKind=1 and OperatorID=@OperatorID",values:new object[] {startDate, operatorId });
                if (pageListUserDay == null || pageListUserDay.Count == 0) continue;
                foreach (var item in pageListUserDay)
                {
                    loginUsers.Add(item.UserID);
                }
                await Task.Delay(200);
            }
            return loginUsers;
        }

        /// <summary>
        /// 获取指定日期新增的用户ids数
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="startDate"></param>
        /// <returns></returns>
        private async Task<HashSet<string>> GetOperNewUserIds(string operatorId, DateTime startDate)
        {
            var pageCount = await _sUserDayMo.GetPageCountAsync(PAGESIZE, $"DayID=@DayID and UserKind=1 and OperatorID=@OperatorID and IsNew=1",values:new object[] { startDate,operatorId});
            if (pageCount == 0) return null;
            //昨天登录的用户数
            var registerUsers = new HashSet<string>();
            List<S_user_dayEO> pageListUserDay = null;
            for (var page = 1; page <= pageCount; page++)
            {
                pageListUserDay = await _sUserDayMo.GetPagerListAsync(PAGESIZE, page, $"DayID=@DayID and UserKind=1 and OperatorID=@OperatorID and IsNew=1",values:new object[] { startDate, operatorId });
                if (pageListUserDay == null || pageListUserDay.Count == 0) continue;
                foreach (var item in pageListUserDay)
                {
                    registerUsers.Add(item.UserID);
                }
                await Task.Delay(200);
            }
            return registerUsers;
        }


        /// <summary>
        /// 获取指定日期注册的用户ids数
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="startDate"></param>
        /// <returns></returns>
        private async Task<HashSet<string>> GetOperRegisterUserIds(string operatorId, DateTime startDate)
        {
            var pageCount = await _sUserDayMo.GetPageCountAsync(PAGESIZE, $"DayID=@DayID and UserKind=1 and OperatorID=@OperatorID and IsRegister=1",values:new object[] { startDate, operatorId });
            if (pageCount == 0) return null;
            //昨天登录的用户数
            var registerUsers = new HashSet<string>();
            List<S_user_dayEO> pageListUserDay = null;
            for (var page = 1; page <= pageCount; page++)
            {
                pageListUserDay = await _sUserDayMo.GetPagerListAsync(PAGESIZE, page, $"DayID=@DayID and UserKind=1 and OperatorID=@OperatorID and IsRegister=1",values:new object[] { startDate, operatorId });
                if (pageListUserDay == null || pageListUserDay.Count == 0) continue;
                foreach (var item in pageListUserDay)
                {
                    registerUsers.Add(item.UserID);
                }
                await Task.Delay(200);
            }
            return registerUsers;
        }

        #endregion
    }
}
