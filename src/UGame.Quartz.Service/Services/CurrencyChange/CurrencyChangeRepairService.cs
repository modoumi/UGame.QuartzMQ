using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Data;
using TinyFx.Logging;
using Xxyy.Common.Services;
using Xxyy.DAL;

namespace UGame.Quartz.Service.Services.CurrencyChange
{
    public class CurrencyChangeRepairService
    {
        private UserService _userSvc;
        private S_currency_changeMO _changeMo = new();

        /// <summary>
        /// 修复lobby升级common之前的数据
        /// </summary>
        /// <returns></returns>
        public async Task<CurRepairDto> RepairUpgradeBefore(int repairCount = 1)
        {
            var ret = new CurRepairDto();
            int tmpCount = 0;
            TransactionManager tm = new TransactionManager();
            try
            {
                var historyDataList = await _changeMo.GetSortAsync("Amount<0 and RecDate<='2023-08-17 09:00:00' and CountryID='BRA'", "RecDate desc");
                if (historyDataList != null && historyDataList.Any())
                {
                    var groupData = historyDataList.GroupBy(h => h.SourceId).Where(g => g.Count() == 2);
                    if (groupData != null && groupData.Any())
                    {
                        ret.RepairDetails = new List<RepairDetail>();
                        foreach (var group in groupData)
                        {
                            var itemList = group.ToList();
                            var keepItem = itemList[0];
                            var deleteItem = itemList[1];

                            if (Math.Abs(itemList[0].Amount) < Math.Abs(itemList[1].Amount))
                            {
                                keepItem = itemList[1];
                                deleteItem = itemList[0];
                            }
                            keepItem.AmountBonus = deleteItem.Amount;

                            if (await _changeMo.PutAsync(keepItem, tm) > 0 && await _changeMo.RemoveAsync(deleteItem, tm) > 0)
                            {
                                var _repairDetail = new RepairDetail() { SourceId = keepItem.SourceId, UserId = keepItem.UserID };
                                ret.RepairDetails.Add(_repairDetail);
                                tmpCount++;
                                if (repairCount > 0 && tmpCount == repairCount) break;
                            }
                            else
                                continue;
                        }
                    }
                }
                ret.RepairCount = tmpCount;
                tm.Commit();
            }
            catch (Exception ex)
            {
                tm.Rollback();
                ret.RepairCount = 0;
                ret.RepairDetails = new List<RepairDetail>();
                LogUtil.Error(ex, "修复lobby升级common之前的数据出错");
            }
            return ret;

        }

        /// <summary>
        /// 修复lobby升级common之后的数据
        /// </summary>
        /// <returns></returns>
        public async Task<CurRepairDto> RepairUpgradeAfter(int repairCount = 1)
        {
            var ret = new CurRepairDto();
            int tmpCount = 0;
            TransactionManager tm = new TransactionManager();
            try
            {
                var historyDataList = await _changeMo.GetSortAsync("Amount<0 and RecDate>'2023-08-17 09:00:00'", "RecDate desc");
                if (historyDataList != null && historyDataList.Any())
                {
                    var groupData = historyDataList.GroupBy(h => h.SourceId).Where(g => g.Count() == 2);
                    if (groupData != null && groupData.Any())
                    {
                        ret.RepairDetails = new List<RepairDetail>();
                        foreach (var group in groupData)
                        {
                            var itemList = group.ToList();
                            var keepItem = itemList[0];
                            var deleteItem = itemList[1];

                            if (keepItem.IsBonus && deleteItem.IsBonus) continue;

                            if (itemList[0].IsBonus)
                            {
                                keepItem = itemList[1];
                                deleteItem = itemList[0];
                            }

                            keepItem.AmountBonus = deleteItem.Amount;
                            keepItem.Amount = keepItem.Amount + deleteItem.Amount;
                            keepItem.PlanAmount = keepItem.PlanAmount + deleteItem.PlanAmount;

                            if (await _changeMo.PutAsync(keepItem, tm) > 0 && await _changeMo.RemoveAsync(deleteItem, tm) > 0)
                            {
                                var _repairDetail = new RepairDetail() { SourceId = keepItem.SourceId, UserId = keepItem.UserID };
                                ret.RepairDetails.Add(_repairDetail);
                                tmpCount++;
                                if (repairCount > 0 && tmpCount == repairCount) break;
                            }
                            else
                                continue;
                        }
                    }
                }
                ret.RepairCount = tmpCount;
                tm.Commit();
            }
            catch (Exception ex)
            {
                tm.Rollback();
                ret.RepairCount = 0;
                ret.RepairDetails = new List<RepairDetail>();
                LogUtil.Error(ex, "修复lobby升级common之后的数据出错");
            }
            return ret;
        }

        /// <summary>   
        /// 修复提现审核拒绝的数据
        /// </summary>
        /// <returns></returns>
        public async Task<CurRepairDto> RepairAuditRejected(int repairCount = 1)
        {
            var ret = new CurRepairDto();
            int tmpCount = 0;
            TransactionManager tm = new TransactionManager();
            try
            {
                var historyDataList = await _changeMo.GetSortAsync("Reason = '提现审核拒绝' and CountryID='BRA'", "RecDate desc");
                if (historyDataList != null && historyDataList.Any())
                {
                    var groupData = historyDataList.GroupBy(h => h.SourceId).Where(g => g.Count() == 2);
                    if (groupData != null && groupData.Any())
                    {
                        ret.RepairDetails = new List<RepairDetail>();
                        foreach (var group in groupData)
                        {
                            var itemList = group.ToList();
                            var keepItem = itemList[0];
                            var deleteItem = itemList[1];

                            if (keepItem.IsBonus && deleteItem.IsBonus) continue;

                            if (itemList[0].IsBonus)
                            {
                                keepItem = itemList[1];
                                deleteItem = itemList[0];
                            }

                            keepItem.AmountBonus = deleteItem.Amount;

                            if (await _changeMo.PutAsync(keepItem, tm) > 0 && await _changeMo.RemoveAsync(deleteItem, tm) > 0)
                            {
                                var _repairDetail = new RepairDetail() { SourceId = keepItem.SourceId, UserId = keepItem.UserID };
                                ret.RepairDetails.Add(_repairDetail);
                                tmpCount++;
                                if (repairCount > 0 && tmpCount == repairCount) break;
                            }
                            else
                                continue;
                        }
                    }
                }
                ret.RepairCount = tmpCount;
                tm.Commit();
            }
            catch (Exception ex)
            {
                tm.Rollback();
                ret.RepairCount = 0;
                ret.RepairDetails = new List<RepairDetail>();
                LogUtil.Error(ex, "修复提现审核拒绝的数据出错");
            }
            return ret;
        }
    }

    public class CurRepairDto
    {
        public int RepairCount { get; set; }

        public List<RepairDetail> RepairDetails { get; set; }
    }

    public class RepairDetail
    {
        public string UserId { get; set; }

        public string SourceId { get; set; }
    }
}
