using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xxyy.Common;

namespace UGame.Quartz.Service.Services.ClearData
{

    public enum ClearDataEnum
    { 
        notify = 1
    }

    public class ClearDataServiceFactory
    {
        public static IClearDataService CreateClearDataService(ClearDataEnum clearDataEnum)
        {
            return clearDataEnum switch
            {
                ClearDataEnum.notify => new ClearNotifyService(),
                _ => null
            };
        }
    }

    public interface IClearDataService
    {
        Task<string> Clear();    
    }


    public class ClearNotifyService : IClearDataService
    {
        public async Task<string> Clear()
        {
            var ret = string.Empty;

            var sqlDic = BuildSql();

            foreach (var item in sqlDic)
            {
                ret += $"{item.Key}:{await DbSink.MainDb.ExecSqlNonQueryAsync(item.Value)};";
            }

            return ret;
        }

        private Dictionary<string,string> BuildSql()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var whereIn = "select NotifyID from sc_notify where NOW() not BETWEEN BeginDate and EndDate";

            dic.Add("sc_notify_detail", $"delete from sc_notify_detail where NotifyID in({whereIn});");
            dic.Add("sc_notify_user", $"delete from sc_notify_user where NotifyID in({whereIn});");
            dic.Add("sc_notify_user_log", $"delete from sc_notify_user_log where NotifyID in({whereIn});");
            dic.Add("sc_notify", $"delete from sc_notify where NOW() not BETWEEN BeginDate and EndDate;");

            //dic.Add("sc_notify_detail", $"delete from sc_notify_detail where NotifyID = '650168483a7a2387f58f427a';");
            //dic.Add("sc_notify_user", $"delete from sc_notify_user where NotifyID = '650168483a7a2387f58f427a';");
            //dic.Add("sc_notify_user_log", $"delete from sc_notify_user_log where NotifyID = '650168483a7a2387f58f427a';");
            //dic.Add("sc_notify", $"delete from sc_notify where NotifyID = '650168483a7a2387f58f427a';");

            return dic;
        }
    }

    public class ClearDataService
    {

        public async Task<string> Execute()
        {
            var ret = string.Empty;

            foreach (ClearDataEnum clearDataEnum in Enum.GetValues(typeof(ClearDataEnum)))
            {
                var clearDataService = ClearDataServiceFactory.CreateClearDataService(clearDataEnum);
                if (clearDataService == null)
                    continue;

                ret += await clearDataService.Clear();
            }

            return ret;
        }

    }

}
