/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2024-06-12 19: 49:27
 ******************************************************/
using System;
using System.Data;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using TinyFx;
using TinyFx.Data;
using MySql.Data.MySqlClient;
using TinyFx.Data.MySql;

namespace UGame.Quartz.Repository
{
	#region EO
	/// <summary>
	/// 
	/// 【视图 v_sr_channel_day 的实体类】
	/// </summary>
	[Serializable]
	[Obsolete]
	public class V_sr_channel_dayEO : IRowMapper<V_sr_channel_dayEO>
	{
		#region 所有字段
		/// <summary>
		/// 统计日
		/// 【字段 date】
		/// </summary>
		[DataMember(Order = 1)]
		public DateTime DayID { get; set; }
		/// <summary>
		/// 推广渠道编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string ChannelID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 新增用户数DNU
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int NewUsers { get; set; }
		/// <summary>
		/// 登录用户DAU
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int LoginUsers { get; set; }
		/// <summary>
		/// 注册用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int RegUsers { get; set; }
		/// <summary>
		/// 
		/// 【字段 decimal(14,4)】
		/// </summary>
		[DataMember(Order = 7)]
		public decimal? RegRate { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long LoginOldUsers { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long OldPayUsers { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long OldUserPayAmount { get; set; }
		/// <summary>
		/// 
		/// 【字段 decimal(14,4)】
		/// </summary>
		[DataMember(Order = 11)]
		public decimal? DAU_BetRate { get; set; }
		/// <summary>
		/// 
		/// 【字段 decimal(14,4)】
		/// </summary>
		[DataMember(Order = 12)]
		public decimal? DNU_BetRate { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 13)]
		public long DOU_BetAmount { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 14)]
		public long DOU_BetUsers { get; set; }
		/// <summary>
		/// 
		/// 【字段 decimal(15,4)】
		/// </summary>
		[DataMember(Order = 15)]
		public decimal? DOU_BetRate { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 16)]
		public long DAU_GGR { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 17)]
		public long DNU_GGR { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 18)]
		public long OldUserCashAmount { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 19)]
		public long OldUserWinAmount { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 20)]
		public long DOU_BetBonus { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 21)]
		public long DOU_BetCash { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 22)]
		public long DOU_GGR { get; set; }
		/// <summary>
		/// 
		/// 【字段 decimal(14,4)】
		/// </summary>
		[DataMember(Order = 23)]
		public decimal? DNU_FirstPayRate { get; set; }
		/// <summary>
		/// 
		/// 【字段 decimal(14,4)】
		/// </summary>
		[DataMember(Order = 24)]
		public decimal? DNU_RepayRate { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 25)]
		public long DNU_RepayAmount { get; set; }
		/// <summary>
		/// 
		/// 【字段 decimal(14,4)】
		/// </summary>
		[DataMember(Order = 26)]
		public decimal? DOU_FirstPayRate { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 27)]
		public long DOU_RepayUsers { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 28)]
		public long DOU_RepayAmount { get; set; }
		/// <summary>
		/// 
		/// 【字段 decimal(16,4)】
		/// </summary>
		[DataMember(Order = 29)]
		public decimal? DOU_RepayRate { get; set; }
		/// <summary>
		/// 下注用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 30)]
		public int BetUsers { get; set; }
		/// <summary>
		/// 新下注用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 31)]
		public int NewBetUsers { get; set; }
		/// <summary>
		/// 新用户下注额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 32)]
		public long NewUserBetAmount { get; set; }
		/// <summary>
		/// 新用户下注的bonus
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 33)]
		public long NewUserBetBonus { get; set; }
		/// <summary>
		/// 新用户返奖bonus
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 34)]
		public long NewUserWinBonus { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 35)]
		public long NewUserWinCash { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 36)]
		public long NewUserBetCash { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 37)]
		public long DOU_WinBonus { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 38)]
		public long DOU_WinCash { get; set; }
		/// <summary>
		/// 当日所有账户总存量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 39)]
		public long TotalBalance { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 40)]
		public long TotalCashAmount { get; set; }
		/// <summary>
		/// 下注数量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 41)]
		public long BetAmount { get; set; }
		/// <summary>
		/// 下注时扣除的bonus
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 42)]
		public long BetBonus { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 43)]
		public long BetCash { get; set; }
		/// <summary>
		/// 返奖数量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 44)]
		public long WinAmount { get; set; }
		/// <summary>
		/// 返奖时增加的bonus
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 45)]
		public long WinBonus { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 46)]
		public long WinCash { get; set; }
		/// <summary>
		/// 充值用户数PU
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 47)]
		public int PayUsers { get; set; }
		/// <summary>
		/// 新充值用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 48)]
		public int NewPayUsers { get; set; }
		/// <summary>
		/// 充值未下注用户数量
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 49)]
		public int PayNotBetUsers { get; set; }
		/// <summary>
		/// 当日首充(历史未充值)的老用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 50)]
		public int DOU_FirstPayUsers { get; set; }
		/// <summary>
		/// DNU复充用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 51)]
		public int DNU_RepayUsers { get; set; }
		/// <summary>
		/// 回流用户
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 52)]
		public int RepeatConsumersD1 { get; set; }
		/// <summary>
		/// 回流用户(5日）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 53)]
		public int RepeatConsumersD5 { get; set; }
		/// <summary>
		/// 回流用户(10日)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 54)]
		public int RepeatConsumersD10 { get; set; }
		/// <summary>
		/// 回流用户(15日)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 55)]
		public int RepeatConsumersD15 { get; set; }
		/// <summary>
		/// DNU首充金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 56)]
		public long DNU_FirstPayAmount { get; set; }
		/// <summary>
		/// 老用户当日首充的累计金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 57)]
		public long DOU_FirstPayAmount { get; set; }
		/// <summary>
		/// 充值我方手续费
		/// 【字段 decimal(20,2)】
		/// </summary>
		[DataMember(Order = 58)]
		public decimal PayOwnFee { get; set; }
		/// <summary>
		/// 充值用户手续费
		/// 【字段 decimal(20,2)】
		/// </summary>
		[DataMember(Order = 59)]
		public decimal PayUserFee { get; set; }
		/// <summary>
		/// 新用户充值额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 60)]
		public long NewUserPayAmount { get; set; }
		/// <summary>
		/// 充值数量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 61)]
		public long PayAmount { get; set; }
		/// <summary>
		/// 提现用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 62)]
		public int CashUsers { get; set; }
		/// <summary>
		/// 新提现用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 63)]
		public int NewCashUsers { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 64)]
		public long DOU_CashUsers { get; set; }
		/// <summary>
		/// 提现我方手续费
		/// 【字段 decimal(20,2)】
		/// </summary>
		[DataMember(Order = 65)]
		public decimal CashOwnFee { get; set; }
		/// <summary>
		/// 提现用户手续费
		/// 【字段 decimal(20,2)】
		/// </summary>
		[DataMember(Order = 66)]
		public decimal CashUserFee { get; set; }
		/// <summary>
		/// 新用户提现额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 67)]
		public long NewUserCashAmount { get; set; }
		/// <summary>
		/// 新用户返奖额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 68)]
		public long NewUserWinAmount { get; set; }
		/// <summary>
		/// 提现数量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 69)]
		public long CashAmount { get; set; }
		/// <summary>
		/// bonus领取人数
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 70)]
		public long BonusRecUsers { get; set; }
		/// <summary>
		/// bonus发放总量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 71)]
		public long BonusAmount { get; set; }
		/// <summary>
		/// bonus消耗总量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 72)]
		public long BonusUseAmount { get; set; }
		/// <summary>
		/// bonus存量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 73)]
		public long BonusRemainAmount { get; set; }
		/// <summary>
		/// bonus解锁金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 74)]
		public long BonusUnlockAmount { get; set; }
		/// <summary>
		/// 提审现金额度
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 75)]
		public long CashAuditAmount { get; set; }
		/// <summary>
		/// 拒审现金额度
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 76)]
		public long CashRefuseAmount { get; set; }
		/// <summary>
		/// 通过现金额度
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 77)]
		public long CashPassAmount { get; set; }
		/// <summary>
		/// 失败金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 78)]
		public long CashFailAmount { get; set; }
		/// <summary>
		/// 盈利数量GGR（下注-返奖-活动）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 79)]
		public long ProfitAmount { get; set; }
		/// <summary>
		/// 活动成本sum（s_currency_change.Amount）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 80)]
		public long PromotionFeeAmount { get; set; }
		/// <summary>
		/// 新用户ARUP（新下注用户数/新用户下注-返奖总额）
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 81)]
		public float NewARUP { get; set; }
		/// <summary>
		/// ARUP
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 82)]
		public float ARUP { get; set; }
		/// <summary>
		/// 
		/// 【字段 decimal(23,4)】
		/// </summary>
		[DataMember(Order = 83)]
		public decimal? Arppu { get; set; }
		/// <summary>
		/// 
		/// 【字段 decimal(23,4)】
		/// </summary>
		[DataMember(Order = 84)]
		public decimal? DNU_arppu { get; set; }
		/// <summary>
		/// 1日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 85)]
		public float RetentionD1 { get; set; }
		/// <summary>
		/// 3日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 86)]
		public float RetentionD3 { get; set; }
		/// <summary>
		/// 7日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 87)]
		public float RetentionD7 { get; set; }
		/// <summary>
		/// 14日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 88)]
		public float RetentionD14 { get; set; }
		/// <summary>
		/// 15日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 89)]
		public float RetentionD15 { get; set; }
		/// <summary>
		/// 20日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 90)]
		public float RetentionD20 { get; set; }
		/// <summary>
		/// 30日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 91)]
		public float RetentionD30 { get; set; }
		/// <summary>
		/// 注册1日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 92)]
		public float RegRetentionD1 { get; set; }
		/// <summary>
		/// 1日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 93)]
		public float RegRetentionD3 { get; set; }
		/// <summary>
		/// 1日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 94)]
		public float RegRetentionD7 { get; set; }
		/// <summary>
		/// 1日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 95)]
		public float RegRetentionD15 { get; set; }
		/// <summary>
		/// 1日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 96)]
		public float RegRetentionD30 { get; set; }
		/// <summary>
		/// 充值1日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 97)]
		public float PayRetentionD1 { get; set; }
		/// <summary>
		/// 充值2日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 98)]
		public float PayRetentionD2 { get; set; }
		/// <summary>
		/// 充值3日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 99)]
		public float PayRetentionD3 { get; set; }
		/// <summary>
		/// 充值4日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 100)]
		public float PayRetentionD4 { get; set; }
		/// <summary>
		/// 充值5日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 101)]
		public float PayRetentionD5 { get; set; }
		/// <summary>
		/// 充值6日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 102)]
		public float PayRetentionD6 { get; set; }
		/// <summary>
		/// 充值7日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 103)]
		public float PayRetentionD7 { get; set; }
		/// <summary>
		/// 充值14日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 104)]
		public float PayRetentionD14 { get; set; }
		/// <summary>
		/// 充值20日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 105)]
		public float PayRetentionD20 { get; set; }
		/// <summary>
		/// 充值30日留存率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 106)]
		public float PayRetentionD30 { get; set; }
		/// <summary>
		/// DNU_GGR1
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 107)]
		public long DNU_GGR1 { get; set; }
		/// <summary>
		/// DNU_GGR2
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 108)]
		public long DNU_GGR2 { get; set; }
		/// <summary>
		/// DNU_GGR3
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 109)]
		public long DNU_GGR3 { get; set; }
		/// <summary>
		/// DNU_GGR4
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 110)]
		public long DNU_GGR4 { get; set; }
		/// <summary>
		/// DNU_GGR5
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 111)]
		public long DNU_GGR5 { get; set; }
		/// <summary>
		/// DNU_GGR6
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 112)]
		public long DNU_GGR6 { get; set; }
		/// <summary>
		/// DNU_GGR7
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 113)]
		public long DNU_GGR7 { get; set; }
		/// <summary>
		/// DNU_GGR8
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 114)]
		public long DNU_GGR8 { get; set; }
		/// <summary>
		/// DNU_GGR9
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 115)]
		public long DNU_GGR9 { get; set; }
		/// <summary>
		/// DNU_GGR10
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 116)]
		public long DNU_GGR10 { get; set; }
		/// <summary>
		/// DNU_GGR11
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 117)]
		public long DNU_GGR11 { get; set; }
		/// <summary>
		/// DNU_GGR12
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 118)]
		public long DNU_GGR12 { get; set; }
		/// <summary>
		/// DNU_GGR13
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 119)]
		public long DNU_GGR13 { get; set; }
		/// <summary>
		/// DNU_GGR14
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 120)]
		public long DNU_GGR14 { get; set; }
		/// <summary>
		/// DNU_GGR15
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 121)]
		public long DNU_GGR15 { get; set; }
		/// <summary>
		/// DNU_GGR16
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 122)]
		public long DNU_GGR16 { get; set; }
		/// <summary>
		/// DNU_GGR17
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 123)]
		public long DNU_GGR17 { get; set; }
		/// <summary>
		/// DNU_GGR18
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 124)]
		public long DNU_GGR18 { get; set; }
		/// <summary>
		/// DNU_GGR19
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 125)]
		public long DNU_GGR19 { get; set; }
		/// <summary>
		/// DNU_GGR20
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 126)]
		public long DNU_GGR20 { get; set; }
		/// <summary>
		/// DNU_GGR21
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 127)]
		public long DNU_GGR21 { get; set; }
		/// <summary>
		/// DNU_GGR22
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 128)]
		public long DNU_GGR22 { get; set; }
		/// <summary>
		/// DNU_GGR23
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 129)]
		public long DNU_GGR23 { get; set; }
		/// <summary>
		/// DNU_GGR24
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 130)]
		public long DNU_GGR24 { get; set; }
		/// <summary>
		/// DNU_GGR25
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 131)]
		public long DNU_GGR25 { get; set; }
		/// <summary>
		/// DNU_GGR26
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 132)]
		public long DNU_GGR26 { get; set; }
		/// <summary>
		/// DNU_GGR27
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 133)]
		public long DNU_GGR27 { get; set; }
		/// <summary>
		/// DNU_GGR28
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 134)]
		public long DNU_GGR28 { get; set; }
		/// <summary>
		/// DNU_GGR29
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 135)]
		public long DNU_GGR29 { get; set; }
		/// <summary>
		/// DNU_GGR30
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 136)]
		public long DNU_GGR30 { get; set; }
		/// <summary>
		/// 输10
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 137)]
		public int Lose10 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 138)]
		public int Lose10_100 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 139)]
		public int Lose100_500 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 140)]
		public int Lose500_1000 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 141)]
		public int Lose1000_3000 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 142)]
		public int Lose3000_5000 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 143)]
		public int Lose5000_10000 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 144)]
		public int Lose10000_50000 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 145)]
		public int Lose50000 { get; set; }
		/// <summary>
		/// 输10
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 146)]
		public int Win10 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 147)]
		public int Win10_100 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 148)]
		public int Win100_500 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 149)]
		public int Win500_1000 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 150)]
		public int Win1000_3000 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 151)]
		public int Win3000_5000 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 152)]
		public int Win5000_10000 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 153)]
		public int Win10000_50000 { get; set; }
		/// <summary>
		/// 输10-100人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 154)]
		public int Win50000 { get; set; }
		/// <summary>
		/// 下注一日留存
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 155)]
		public float BetD1 { get; set; }
		/// <summary>
		/// 注册用户复充人均下注
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 156)]
		public float RMPbet { get; set; }
		/// <summary>
		/// 注册用户单充人均下注
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 157)]
		public float RSPbet { get; set; }
		/// <summary>
		/// 充值用户复充人均下注
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 158)]
		public float PMPbet { get; set; }
		/// <summary>
		/// 充值用户单充人均下注
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 159)]
		public float PSPbet { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 160)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public V_sr_channel_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static V_sr_channel_dayEO MapDataReader(IDataReader reader)
		{
		    V_sr_channel_dayEO ret = new V_sr_channel_dayEO();
			ret.DayID = reader.ToDateTime("DayID");
			ret.ChannelID = reader.ToString("ChannelID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.NewUsers = reader.ToInt32("NewUsers");
			ret.LoginUsers = reader.ToInt32("LoginUsers");
			ret.RegUsers = reader.ToInt32("RegUsers");
			ret.RegRate = reader.ToDecimalN("RegRate");
			ret.LoginOldUsers = reader.ToInt64("LoginOldUsers");
			ret.OldPayUsers = reader.ToInt64("OldPayUsers");
			ret.OldUserPayAmount = reader.ToInt64("OldUserPayAmount");
			ret.DAU_BetRate = reader.ToDecimalN("DAU_BetRate");
			ret.DNU_BetRate = reader.ToDecimalN("DNU_BetRate");
			ret.DOU_BetAmount = reader.ToInt64("DOU_BetAmount");
			ret.DOU_BetUsers = reader.ToInt64("DOU_BetUsers");
			ret.DOU_BetRate = reader.ToDecimalN("DOU_BetRate");
			ret.DAU_GGR = reader.ToInt64("DAU_GGR");
			ret.DNU_GGR = reader.ToInt64("DNU_GGR");
			ret.OldUserCashAmount = reader.ToInt64("OldUserCashAmount");
			ret.OldUserWinAmount = reader.ToInt64("OldUserWinAmount");
			ret.DOU_BetBonus = reader.ToInt64("DOU_BetBonus");
			ret.DOU_BetCash = reader.ToInt64("DOU_BetCash");
			ret.DOU_GGR = reader.ToInt64("DOU_GGR");
			ret.DNU_FirstPayRate = reader.ToDecimalN("DNU_FirstPayRate");
			ret.DNU_RepayRate = reader.ToDecimalN("DNU_RepayRate");
			ret.DNU_RepayAmount = reader.ToInt64("DNU_RepayAmount");
			ret.DOU_FirstPayRate = reader.ToDecimalN("DOU_FirstPayRate");
			ret.DOU_RepayUsers = reader.ToInt64("DOU_RepayUsers");
			ret.DOU_RepayAmount = reader.ToInt64("DOU_RepayAmount");
			ret.DOU_RepayRate = reader.ToDecimalN("DOU_RepayRate");
			ret.BetUsers = reader.ToInt32("BetUsers");
			ret.NewBetUsers = reader.ToInt32("NewBetUsers");
			ret.NewUserBetAmount = reader.ToInt64("NewUserBetAmount");
			ret.NewUserBetBonus = reader.ToInt64("NewUserBetBonus");
			ret.NewUserWinBonus = reader.ToInt64("NewUserWinBonus");
			ret.NewUserWinCash = reader.ToInt64("NewUserWinCash");
			ret.NewUserBetCash = reader.ToInt64("NewUserBetCash");
			ret.DOU_WinBonus = reader.ToInt64("DOU_WinBonus");
			ret.DOU_WinCash = reader.ToInt64("DOU_WinCash");
			ret.TotalBalance = reader.ToInt64("TotalBalance");
			ret.TotalCashAmount = reader.ToInt64("TotalCashAmount");
			ret.BetAmount = reader.ToInt64("BetAmount");
			ret.BetBonus = reader.ToInt64("BetBonus");
			ret.BetCash = reader.ToInt64("BetCash");
			ret.WinAmount = reader.ToInt64("WinAmount");
			ret.WinBonus = reader.ToInt64("WinBonus");
			ret.WinCash = reader.ToInt64("WinCash");
			ret.PayUsers = reader.ToInt32("PayUsers");
			ret.NewPayUsers = reader.ToInt32("NewPayUsers");
			ret.PayNotBetUsers = reader.ToInt32("PayNotBetUsers");
			ret.DOU_FirstPayUsers = reader.ToInt32("DOU_FirstPayUsers");
			ret.DNU_RepayUsers = reader.ToInt32("DNU_RepayUsers");
			ret.RepeatConsumersD1 = reader.ToInt32("RepeatConsumersD1");
			ret.RepeatConsumersD5 = reader.ToInt32("RepeatConsumersD5");
			ret.RepeatConsumersD10 = reader.ToInt32("RepeatConsumersD10");
			ret.RepeatConsumersD15 = reader.ToInt32("RepeatConsumersD15");
			ret.DNU_FirstPayAmount = reader.ToInt64("DNU_FirstPayAmount");
			ret.DOU_FirstPayAmount = reader.ToInt64("DOU_FirstPayAmount");
			ret.PayOwnFee = reader.ToDecimal("PayOwnFee");
			ret.PayUserFee = reader.ToDecimal("PayUserFee");
			ret.NewUserPayAmount = reader.ToInt64("NewUserPayAmount");
			ret.PayAmount = reader.ToInt64("PayAmount");
			ret.CashUsers = reader.ToInt32("CashUsers");
			ret.NewCashUsers = reader.ToInt32("NewCashUsers");
			ret.DOU_CashUsers = reader.ToInt64("DOU_CashUsers");
			ret.CashOwnFee = reader.ToDecimal("CashOwnFee");
			ret.CashUserFee = reader.ToDecimal("CashUserFee");
			ret.NewUserCashAmount = reader.ToInt64("NewUserCashAmount");
			ret.NewUserWinAmount = reader.ToInt64("NewUserWinAmount");
			ret.CashAmount = reader.ToInt64("CashAmount");
			ret.BonusRecUsers = reader.ToInt64("BonusRecUsers");
			ret.BonusAmount = reader.ToInt64("BonusAmount");
			ret.BonusUseAmount = reader.ToInt64("BonusUseAmount");
			ret.BonusRemainAmount = reader.ToInt64("BonusRemainAmount");
			ret.BonusUnlockAmount = reader.ToInt64("BonusUnlockAmount");
			ret.CashAuditAmount = reader.ToInt64("CashAuditAmount");
			ret.CashRefuseAmount = reader.ToInt64("CashRefuseAmount");
			ret.CashPassAmount = reader.ToInt64("CashPassAmount");
			ret.CashFailAmount = reader.ToInt64("CashFailAmount");
			ret.ProfitAmount = reader.ToInt64("ProfitAmount");
			ret.PromotionFeeAmount = reader.ToInt64("PromotionFeeAmount");
			ret.NewARUP = reader.ToSingle("NewARUP");
			ret.ARUP = reader.ToSingle("ARUP");
			ret.Arppu = reader.ToDecimalN("Arppu");
			ret.DNU_arppu = reader.ToDecimalN("DNU_arppu");
			ret.RetentionD1 = reader.ToSingle("RetentionD1");
			ret.RetentionD3 = reader.ToSingle("RetentionD3");
			ret.RetentionD7 = reader.ToSingle("RetentionD7");
			ret.RetentionD14 = reader.ToSingle("RetentionD14");
			ret.RetentionD15 = reader.ToSingle("RetentionD15");
			ret.RetentionD20 = reader.ToSingle("RetentionD20");
			ret.RetentionD30 = reader.ToSingle("RetentionD30");
			ret.RegRetentionD1 = reader.ToSingle("RegRetentionD1");
			ret.RegRetentionD3 = reader.ToSingle("RegRetentionD3");
			ret.RegRetentionD7 = reader.ToSingle("RegRetentionD7");
			ret.RegRetentionD15 = reader.ToSingle("RegRetentionD15");
			ret.RegRetentionD30 = reader.ToSingle("RegRetentionD30");
			ret.PayRetentionD1 = reader.ToSingle("PayRetentionD1");
			ret.PayRetentionD2 = reader.ToSingle("PayRetentionD2");
			ret.PayRetentionD3 = reader.ToSingle("PayRetentionD3");
			ret.PayRetentionD4 = reader.ToSingle("PayRetentionD4");
			ret.PayRetentionD5 = reader.ToSingle("PayRetentionD5");
			ret.PayRetentionD6 = reader.ToSingle("PayRetentionD6");
			ret.PayRetentionD7 = reader.ToSingle("PayRetentionD7");
			ret.PayRetentionD14 = reader.ToSingle("PayRetentionD14");
			ret.PayRetentionD20 = reader.ToSingle("PayRetentionD20");
			ret.PayRetentionD30 = reader.ToSingle("PayRetentionD30");
			ret.DNU_GGR1 = reader.ToInt64("DNU_GGR1");
			ret.DNU_GGR2 = reader.ToInt64("DNU_GGR2");
			ret.DNU_GGR3 = reader.ToInt64("DNU_GGR3");
			ret.DNU_GGR4 = reader.ToInt64("DNU_GGR4");
			ret.DNU_GGR5 = reader.ToInt64("DNU_GGR5");
			ret.DNU_GGR6 = reader.ToInt64("DNU_GGR6");
			ret.DNU_GGR7 = reader.ToInt64("DNU_GGR7");
			ret.DNU_GGR8 = reader.ToInt64("DNU_GGR8");
			ret.DNU_GGR9 = reader.ToInt64("DNU_GGR9");
			ret.DNU_GGR10 = reader.ToInt64("DNU_GGR10");
			ret.DNU_GGR11 = reader.ToInt64("DNU_GGR11");
			ret.DNU_GGR12 = reader.ToInt64("DNU_GGR12");
			ret.DNU_GGR13 = reader.ToInt64("DNU_GGR13");
			ret.DNU_GGR14 = reader.ToInt64("DNU_GGR14");
			ret.DNU_GGR15 = reader.ToInt64("DNU_GGR15");
			ret.DNU_GGR16 = reader.ToInt64("DNU_GGR16");
			ret.DNU_GGR17 = reader.ToInt64("DNU_GGR17");
			ret.DNU_GGR18 = reader.ToInt64("DNU_GGR18");
			ret.DNU_GGR19 = reader.ToInt64("DNU_GGR19");
			ret.DNU_GGR20 = reader.ToInt64("DNU_GGR20");
			ret.DNU_GGR21 = reader.ToInt64("DNU_GGR21");
			ret.DNU_GGR22 = reader.ToInt64("DNU_GGR22");
			ret.DNU_GGR23 = reader.ToInt64("DNU_GGR23");
			ret.DNU_GGR24 = reader.ToInt64("DNU_GGR24");
			ret.DNU_GGR25 = reader.ToInt64("DNU_GGR25");
			ret.DNU_GGR26 = reader.ToInt64("DNU_GGR26");
			ret.DNU_GGR27 = reader.ToInt64("DNU_GGR27");
			ret.DNU_GGR28 = reader.ToInt64("DNU_GGR28");
			ret.DNU_GGR29 = reader.ToInt64("DNU_GGR29");
			ret.DNU_GGR30 = reader.ToInt64("DNU_GGR30");
			ret.Lose10 = reader.ToInt32("Lose10");
			ret.Lose10_100 = reader.ToInt32("Lose10_100");
			ret.Lose100_500 = reader.ToInt32("Lose100_500");
			ret.Lose500_1000 = reader.ToInt32("Lose500_1000");
			ret.Lose1000_3000 = reader.ToInt32("Lose1000_3000");
			ret.Lose3000_5000 = reader.ToInt32("Lose3000_5000");
			ret.Lose5000_10000 = reader.ToInt32("Lose5000_10000");
			ret.Lose10000_50000 = reader.ToInt32("Lose10000_50000");
			ret.Lose50000 = reader.ToInt32("Lose50000");
			ret.Win10 = reader.ToInt32("Win10");
			ret.Win10_100 = reader.ToInt32("Win10_100");
			ret.Win100_500 = reader.ToInt32("Win100_500");
			ret.Win500_1000 = reader.ToInt32("Win500_1000");
			ret.Win1000_3000 = reader.ToInt32("Win1000_3000");
			ret.Win3000_5000 = reader.ToInt32("Win3000_5000");
			ret.Win5000_10000 = reader.ToInt32("Win5000_10000");
			ret.Win10000_50000 = reader.ToInt32("Win10000_50000");
			ret.Win50000 = reader.ToInt32("Win50000");
			ret.BetD1 = reader.ToSingle("BetD1");
			ret.RMPbet = reader.ToSingle("RMPbet");
			ret.RSPbet = reader.ToSingle("RSPbet");
			ret.PMPbet = reader.ToSingle("PMPbet");
			ret.PSPbet = reader.ToSingle("PSPbet");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【视图 v_sr_channel_day 的操作类】
	/// </summary>
	[Obsolete]
	public class V_sr_channel_dayMO : MySqlViewMO<V_sr_channel_dayEO>
	{
		/// <summary>
		/// 视图名
		/// </summary>
	    public override string ViewName { get; set; } = "`v_sr_channel_day`"; 
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public V_sr_channel_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public V_sr_channel_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public V_sr_channel_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
		#region Get
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDayID(DateTime dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDayID(DateTime dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDayID(DateTime dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDayID(DateTime dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDayID(DateTime dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDayID(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDayID(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetByChannelID
		
		/// <summary>
		/// 按 ChannelID（字段） 查询
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByChannelID(string channelID)
		{
			return GetByChannelID(channelID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChannelID（字段） 查询
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByChannelID(string channelID, TransactionManager tm_)
		{
			return GetByChannelID(channelID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChannelID（字段） 查询
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByChannelID(string channelID, int top_)
		{
			return GetByChannelID(channelID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChannelID（字段） 查询
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByChannelID(string channelID, int top_, TransactionManager tm_)
		{
			return GetByChannelID(channelID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChannelID（字段） 查询
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByChannelID(string channelID, string sort_)
		{
			return GetByChannelID(channelID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ChannelID（字段） 查询
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByChannelID(string channelID, string sort_, TransactionManager tm_)
		{
			return GetByChannelID(channelID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ChannelID（字段） 查询
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByChannelID(string channelID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChannelID` = @ChannelID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByChannelID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByNewUsers
		
		/// <summary>
		/// 按 NewUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newUsers">新增用户数DNU</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUsers(int newUsers)
		{
			return GetByNewUsers(newUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newUsers">新增用户数DNU</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUsers(int newUsers, TransactionManager tm_)
		{
			return GetByNewUsers(newUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newUsers">新增用户数DNU</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUsers(int newUsers, int top_)
		{
			return GetByNewUsers(newUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newUsers">新增用户数DNU</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUsers(int newUsers, int top_, TransactionManager tm_)
		{
			return GetByNewUsers(newUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newUsers">新增用户数DNU</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUsers(int newUsers, string sort_)
		{
			return GetByNewUsers(newUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newUsers">新增用户数DNU</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUsers(int newUsers, string sort_, TransactionManager tm_)
		{
			return GetByNewUsers(newUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newUsers">新增用户数DNU</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUsers(int newUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUsers` = @NewUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewUsers", newUsers, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewUsers
		#region GetByLoginUsers
		
		/// <summary>
		/// 按 LoginUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginUsers">登录用户DAU</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginUsers(int loginUsers)
		{
			return GetByLoginUsers(loginUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LoginUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginUsers">登录用户DAU</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginUsers(int loginUsers, TransactionManager tm_)
		{
			return GetByLoginUsers(loginUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LoginUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginUsers">登录用户DAU</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginUsers(int loginUsers, int top_)
		{
			return GetByLoginUsers(loginUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LoginUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginUsers">登录用户DAU</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginUsers(int loginUsers, int top_, TransactionManager tm_)
		{
			return GetByLoginUsers(loginUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LoginUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginUsers">登录用户DAU</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginUsers(int loginUsers, string sort_)
		{
			return GetByLoginUsers(loginUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LoginUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginUsers">登录用户DAU</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginUsers(int loginUsers, string sort_, TransactionManager tm_)
		{
			return GetByLoginUsers(loginUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LoginUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginUsers">登录用户DAU</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginUsers(int loginUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LoginUsers` = @LoginUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LoginUsers", loginUsers, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByLoginUsers
		#region GetByRegUsers
		
		/// <summary>
		/// 按 RegUsers（字段） 查询
		/// </summary>
		/// /// <param name = "regUsers">注册用户数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegUsers(int regUsers)
		{
			return GetByRegUsers(regUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegUsers（字段） 查询
		/// </summary>
		/// /// <param name = "regUsers">注册用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegUsers(int regUsers, TransactionManager tm_)
		{
			return GetByRegUsers(regUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegUsers（字段） 查询
		/// </summary>
		/// /// <param name = "regUsers">注册用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegUsers(int regUsers, int top_)
		{
			return GetByRegUsers(regUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegUsers（字段） 查询
		/// </summary>
		/// /// <param name = "regUsers">注册用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegUsers(int regUsers, int top_, TransactionManager tm_)
		{
			return GetByRegUsers(regUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegUsers（字段） 查询
		/// </summary>
		/// /// <param name = "regUsers">注册用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegUsers(int regUsers, string sort_)
		{
			return GetByRegUsers(regUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegUsers（字段） 查询
		/// </summary>
		/// /// <param name = "regUsers">注册用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegUsers(int regUsers, string sort_, TransactionManager tm_)
		{
			return GetByRegUsers(regUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegUsers（字段） 查询
		/// </summary>
		/// /// <param name = "regUsers">注册用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegUsers(int regUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegUsers` = @RegUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RegUsers", regUsers, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRegUsers
		#region GetByRegRate
		
		/// <summary>
		/// 按 RegRate（字段） 查询
		/// </summary>
		/// /// <param name = "regRate"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRate(decimal? regRate)
		{
			return GetByRegRate(regRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegRate（字段） 查询
		/// </summary>
		/// /// <param name = "regRate"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRate(decimal? regRate, TransactionManager tm_)
		{
			return GetByRegRate(regRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegRate（字段） 查询
		/// </summary>
		/// /// <param name = "regRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRate(decimal? regRate, int top_)
		{
			return GetByRegRate(regRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegRate（字段） 查询
		/// </summary>
		/// /// <param name = "regRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRate(decimal? regRate, int top_, TransactionManager tm_)
		{
			return GetByRegRate(regRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegRate（字段） 查询
		/// </summary>
		/// /// <param name = "regRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRate(decimal? regRate, string sort_)
		{
			return GetByRegRate(regRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegRate（字段） 查询
		/// </summary>
		/// /// <param name = "regRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRate(decimal? regRate, string sort_, TransactionManager tm_)
		{
			return GetByRegRate(regRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegRate（字段） 查询
		/// </summary>
		/// /// <param name = "regRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRate(decimal? regRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegRate` = @RegRate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RegRate", regRate.HasValue ? regRate.Value : (object)DBNull.Value, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRegRate
		#region GetByLoginOldUsers
		
		/// <summary>
		/// 按 LoginOldUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginOldUsers"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginOldUsers(long loginOldUsers)
		{
			return GetByLoginOldUsers(loginOldUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LoginOldUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginOldUsers"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginOldUsers(long loginOldUsers, TransactionManager tm_)
		{
			return GetByLoginOldUsers(loginOldUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LoginOldUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginOldUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginOldUsers(long loginOldUsers, int top_)
		{
			return GetByLoginOldUsers(loginOldUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LoginOldUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginOldUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginOldUsers(long loginOldUsers, int top_, TransactionManager tm_)
		{
			return GetByLoginOldUsers(loginOldUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LoginOldUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginOldUsers"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginOldUsers(long loginOldUsers, string sort_)
		{
			return GetByLoginOldUsers(loginOldUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LoginOldUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginOldUsers"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginOldUsers(long loginOldUsers, string sort_, TransactionManager tm_)
		{
			return GetByLoginOldUsers(loginOldUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LoginOldUsers（字段） 查询
		/// </summary>
		/// /// <param name = "loginOldUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLoginOldUsers(long loginOldUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LoginOldUsers` = @LoginOldUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LoginOldUsers", loginOldUsers, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByLoginOldUsers
		#region GetByOldPayUsers
		
		/// <summary>
		/// 按 OldPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "oldPayUsers"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldPayUsers(long oldPayUsers)
		{
			return GetByOldPayUsers(oldPayUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OldPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "oldPayUsers"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldPayUsers(long oldPayUsers, TransactionManager tm_)
		{
			return GetByOldPayUsers(oldPayUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OldPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "oldPayUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldPayUsers(long oldPayUsers, int top_)
		{
			return GetByOldPayUsers(oldPayUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OldPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "oldPayUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldPayUsers(long oldPayUsers, int top_, TransactionManager tm_)
		{
			return GetByOldPayUsers(oldPayUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OldPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "oldPayUsers"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldPayUsers(long oldPayUsers, string sort_)
		{
			return GetByOldPayUsers(oldPayUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OldPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "oldPayUsers"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldPayUsers(long oldPayUsers, string sort_, TransactionManager tm_)
		{
			return GetByOldPayUsers(oldPayUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OldPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "oldPayUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldPayUsers(long oldPayUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OldPayUsers` = @OldPayUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OldPayUsers", oldPayUsers, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByOldPayUsers
		#region GetByOldUserPayAmount
		
		/// <summary>
		/// 按 OldUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserPayAmount"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserPayAmount(long oldUserPayAmount)
		{
			return GetByOldUserPayAmount(oldUserPayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OldUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserPayAmount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserPayAmount(long oldUserPayAmount, TransactionManager tm_)
		{
			return GetByOldUserPayAmount(oldUserPayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OldUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserPayAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserPayAmount(long oldUserPayAmount, int top_)
		{
			return GetByOldUserPayAmount(oldUserPayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OldUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserPayAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserPayAmount(long oldUserPayAmount, int top_, TransactionManager tm_)
		{
			return GetByOldUserPayAmount(oldUserPayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OldUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserPayAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserPayAmount(long oldUserPayAmount, string sort_)
		{
			return GetByOldUserPayAmount(oldUserPayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OldUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserPayAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserPayAmount(long oldUserPayAmount, string sort_, TransactionManager tm_)
		{
			return GetByOldUserPayAmount(oldUserPayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OldUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserPayAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserPayAmount(long oldUserPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OldUserPayAmount` = @OldUserPayAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OldUserPayAmount", oldUserPayAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByOldUserPayAmount
		#region GetByDAU_BetRate
		
		/// <summary>
		/// 按 DAU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_BetRate"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_BetRate(decimal? dAU_BetRate)
		{
			return GetByDAU_BetRate(dAU_BetRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DAU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_BetRate"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_BetRate(decimal? dAU_BetRate, TransactionManager tm_)
		{
			return GetByDAU_BetRate(dAU_BetRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DAU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_BetRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_BetRate(decimal? dAU_BetRate, int top_)
		{
			return GetByDAU_BetRate(dAU_BetRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DAU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_BetRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_BetRate(decimal? dAU_BetRate, int top_, TransactionManager tm_)
		{
			return GetByDAU_BetRate(dAU_BetRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DAU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_BetRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_BetRate(decimal? dAU_BetRate, string sort_)
		{
			return GetByDAU_BetRate(dAU_BetRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DAU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_BetRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_BetRate(decimal? dAU_BetRate, string sort_, TransactionManager tm_)
		{
			return GetByDAU_BetRate(dAU_BetRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DAU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_BetRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_BetRate(decimal? dAU_BetRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DAU_BetRate` = @DAU_BetRate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DAU_BetRate", dAU_BetRate.HasValue ? dAU_BetRate.Value : (object)DBNull.Value, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDAU_BetRate
		#region GetByDNU_BetRate
		
		/// <summary>
		/// 按 DNU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_BetRate"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_BetRate(decimal? dNU_BetRate)
		{
			return GetByDNU_BetRate(dNU_BetRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_BetRate"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_BetRate(decimal? dNU_BetRate, TransactionManager tm_)
		{
			return GetByDNU_BetRate(dNU_BetRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_BetRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_BetRate(decimal? dNU_BetRate, int top_)
		{
			return GetByDNU_BetRate(dNU_BetRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_BetRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_BetRate(decimal? dNU_BetRate, int top_, TransactionManager tm_)
		{
			return GetByDNU_BetRate(dNU_BetRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_BetRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_BetRate(decimal? dNU_BetRate, string sort_)
		{
			return GetByDNU_BetRate(dNU_BetRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_BetRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_BetRate(decimal? dNU_BetRate, string sort_, TransactionManager tm_)
		{
			return GetByDNU_BetRate(dNU_BetRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_BetRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_BetRate(decimal? dNU_BetRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_BetRate` = @DNU_BetRate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_BetRate", dNU_BetRate.HasValue ? dNU_BetRate.Value : (object)DBNull.Value, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_BetRate
		#region GetByDOU_BetAmount
		
		/// <summary>
		/// 按 DOU_BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetAmount"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetAmount(long dOU_BetAmount)
		{
			return GetByDOU_BetAmount(dOU_BetAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetAmount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetAmount(long dOU_BetAmount, TransactionManager tm_)
		{
			return GetByDOU_BetAmount(dOU_BetAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetAmount(long dOU_BetAmount, int top_)
		{
			return GetByDOU_BetAmount(dOU_BetAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetAmount(long dOU_BetAmount, int top_, TransactionManager tm_)
		{
			return GetByDOU_BetAmount(dOU_BetAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetAmount(long dOU_BetAmount, string sort_)
		{
			return GetByDOU_BetAmount(dOU_BetAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetAmount(long dOU_BetAmount, string sort_, TransactionManager tm_)
		{
			return GetByDOU_BetAmount(dOU_BetAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetAmount(long dOU_BetAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_BetAmount` = @DOU_BetAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_BetAmount", dOU_BetAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_BetAmount
		#region GetByDOU_BetUsers
		
		/// <summary>
		/// 按 DOU_BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetUsers"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetUsers(long dOU_BetUsers)
		{
			return GetByDOU_BetUsers(dOU_BetUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetUsers"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetUsers(long dOU_BetUsers, TransactionManager tm_)
		{
			return GetByDOU_BetUsers(dOU_BetUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetUsers(long dOU_BetUsers, int top_)
		{
			return GetByDOU_BetUsers(dOU_BetUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetUsers(long dOU_BetUsers, int top_, TransactionManager tm_)
		{
			return GetByDOU_BetUsers(dOU_BetUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetUsers"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetUsers(long dOU_BetUsers, string sort_)
		{
			return GetByDOU_BetUsers(dOU_BetUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetUsers"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetUsers(long dOU_BetUsers, string sort_, TransactionManager tm_)
		{
			return GetByDOU_BetUsers(dOU_BetUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetUsers(long dOU_BetUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_BetUsers` = @DOU_BetUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_BetUsers", dOU_BetUsers, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_BetUsers
		#region GetByDOU_BetRate
		
		/// <summary>
		/// 按 DOU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetRate"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetRate(decimal? dOU_BetRate)
		{
			return GetByDOU_BetRate(dOU_BetRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetRate"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetRate(decimal? dOU_BetRate, TransactionManager tm_)
		{
			return GetByDOU_BetRate(dOU_BetRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetRate(decimal? dOU_BetRate, int top_)
		{
			return GetByDOU_BetRate(dOU_BetRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetRate(decimal? dOU_BetRate, int top_, TransactionManager tm_)
		{
			return GetByDOU_BetRate(dOU_BetRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetRate(decimal? dOU_BetRate, string sort_)
		{
			return GetByDOU_BetRate(dOU_BetRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetRate(decimal? dOU_BetRate, string sort_, TransactionManager tm_)
		{
			return GetByDOU_BetRate(dOU_BetRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetRate(decimal? dOU_BetRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_BetRate` = @DOU_BetRate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_BetRate", dOU_BetRate.HasValue ? dOU_BetRate.Value : (object)DBNull.Value, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_BetRate
		#region GetByDAU_GGR
		
		/// <summary>
		/// 按 DAU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_GGR"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_GGR(long dAU_GGR)
		{
			return GetByDAU_GGR(dAU_GGR, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DAU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_GGR"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_GGR(long dAU_GGR, TransactionManager tm_)
		{
			return GetByDAU_GGR(dAU_GGR, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DAU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_GGR"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_GGR(long dAU_GGR, int top_)
		{
			return GetByDAU_GGR(dAU_GGR, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DAU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_GGR"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_GGR(long dAU_GGR, int top_, TransactionManager tm_)
		{
			return GetByDAU_GGR(dAU_GGR, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DAU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_GGR"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_GGR(long dAU_GGR, string sort_)
		{
			return GetByDAU_GGR(dAU_GGR, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DAU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_GGR"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_GGR(long dAU_GGR, string sort_, TransactionManager tm_)
		{
			return GetByDAU_GGR(dAU_GGR, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DAU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dAU_GGR"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDAU_GGR(long dAU_GGR, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DAU_GGR` = @DAU_GGR", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DAU_GGR", dAU_GGR, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDAU_GGR
		#region GetByDNU_GGR
		
		/// <summary>
		/// 按 DNU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR(long dNU_GGR)
		{
			return GetByDNU_GGR(dNU_GGR, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR(long dNU_GGR, TransactionManager tm_)
		{
			return GetByDNU_GGR(dNU_GGR, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR(long dNU_GGR, int top_)
		{
			return GetByDNU_GGR(dNU_GGR, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR(long dNU_GGR, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR(dNU_GGR, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR(long dNU_GGR, string sort_)
		{
			return GetByDNU_GGR(dNU_GGR, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR(long dNU_GGR, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR(dNU_GGR, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR(long dNU_GGR, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR` = @DNU_GGR", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR", dNU_GGR, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR
		#region GetByOldUserCashAmount
		
		/// <summary>
		/// 按 OldUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserCashAmount"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserCashAmount(long oldUserCashAmount)
		{
			return GetByOldUserCashAmount(oldUserCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OldUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserCashAmount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserCashAmount(long oldUserCashAmount, TransactionManager tm_)
		{
			return GetByOldUserCashAmount(oldUserCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OldUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserCashAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserCashAmount(long oldUserCashAmount, int top_)
		{
			return GetByOldUserCashAmount(oldUserCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OldUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserCashAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserCashAmount(long oldUserCashAmount, int top_, TransactionManager tm_)
		{
			return GetByOldUserCashAmount(oldUserCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OldUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserCashAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserCashAmount(long oldUserCashAmount, string sort_)
		{
			return GetByOldUserCashAmount(oldUserCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OldUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserCashAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserCashAmount(long oldUserCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByOldUserCashAmount(oldUserCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OldUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserCashAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserCashAmount(long oldUserCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OldUserCashAmount` = @OldUserCashAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OldUserCashAmount", oldUserCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByOldUserCashAmount
		#region GetByOldUserWinAmount
		
		/// <summary>
		/// 按 OldUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserWinAmount"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserWinAmount(long oldUserWinAmount)
		{
			return GetByOldUserWinAmount(oldUserWinAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OldUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserWinAmount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserWinAmount(long oldUserWinAmount, TransactionManager tm_)
		{
			return GetByOldUserWinAmount(oldUserWinAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OldUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserWinAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserWinAmount(long oldUserWinAmount, int top_)
		{
			return GetByOldUserWinAmount(oldUserWinAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OldUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserWinAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserWinAmount(long oldUserWinAmount, int top_, TransactionManager tm_)
		{
			return GetByOldUserWinAmount(oldUserWinAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OldUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserWinAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserWinAmount(long oldUserWinAmount, string sort_)
		{
			return GetByOldUserWinAmount(oldUserWinAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OldUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserWinAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserWinAmount(long oldUserWinAmount, string sort_, TransactionManager tm_)
		{
			return GetByOldUserWinAmount(oldUserWinAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OldUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "oldUserWinAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByOldUserWinAmount(long oldUserWinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OldUserWinAmount` = @OldUserWinAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OldUserWinAmount", oldUserWinAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByOldUserWinAmount
		#region GetByDOU_BetBonus
		
		/// <summary>
		/// 按 DOU_BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetBonus"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetBonus(long dOU_BetBonus)
		{
			return GetByDOU_BetBonus(dOU_BetBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetBonus"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetBonus(long dOU_BetBonus, TransactionManager tm_)
		{
			return GetByDOU_BetBonus(dOU_BetBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetBonus"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetBonus(long dOU_BetBonus, int top_)
		{
			return GetByDOU_BetBonus(dOU_BetBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetBonus"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetBonus(long dOU_BetBonus, int top_, TransactionManager tm_)
		{
			return GetByDOU_BetBonus(dOU_BetBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetBonus"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetBonus(long dOU_BetBonus, string sort_)
		{
			return GetByDOU_BetBonus(dOU_BetBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetBonus"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetBonus(long dOU_BetBonus, string sort_, TransactionManager tm_)
		{
			return GetByDOU_BetBonus(dOU_BetBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetBonus"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetBonus(long dOU_BetBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_BetBonus` = @DOU_BetBonus", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_BetBonus", dOU_BetBonus, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_BetBonus
		#region GetByDOU_BetCash
		
		/// <summary>
		/// 按 DOU_BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetCash"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetCash(long dOU_BetCash)
		{
			return GetByDOU_BetCash(dOU_BetCash, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetCash"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetCash(long dOU_BetCash, TransactionManager tm_)
		{
			return GetByDOU_BetCash(dOU_BetCash, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetCash(long dOU_BetCash, int top_)
		{
			return GetByDOU_BetCash(dOU_BetCash, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetCash(long dOU_BetCash, int top_, TransactionManager tm_)
		{
			return GetByDOU_BetCash(dOU_BetCash, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetCash"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetCash(long dOU_BetCash, string sort_)
		{
			return GetByDOU_BetCash(dOU_BetCash, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetCash"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetCash(long dOU_BetCash, string sort_, TransactionManager tm_)
		{
			return GetByDOU_BetCash(dOU_BetCash, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_BetCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_BetCash(long dOU_BetCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_BetCash` = @DOU_BetCash", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_BetCash", dOU_BetCash, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_BetCash
		#region GetByDOU_GGR
		
		/// <summary>
		/// 按 DOU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_GGR"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_GGR(long dOU_GGR)
		{
			return GetByDOU_GGR(dOU_GGR, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_GGR"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_GGR(long dOU_GGR, TransactionManager tm_)
		{
			return GetByDOU_GGR(dOU_GGR, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_GGR"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_GGR(long dOU_GGR, int top_)
		{
			return GetByDOU_GGR(dOU_GGR, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_GGR"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_GGR(long dOU_GGR, int top_, TransactionManager tm_)
		{
			return GetByDOU_GGR(dOU_GGR, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_GGR"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_GGR(long dOU_GGR, string sort_)
		{
			return GetByDOU_GGR(dOU_GGR, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_GGR"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_GGR(long dOU_GGR, string sort_, TransactionManager tm_)
		{
			return GetByDOU_GGR(dOU_GGR, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_GGR（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_GGR"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_GGR(long dOU_GGR, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_GGR` = @DOU_GGR", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_GGR", dOU_GGR, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_GGR
		#region GetByDNU_FirstPayRate
		
		/// <summary>
		/// 按 DNU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayRate"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayRate(decimal? dNU_FirstPayRate)
		{
			return GetByDNU_FirstPayRate(dNU_FirstPayRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayRate"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayRate(decimal? dNU_FirstPayRate, TransactionManager tm_)
		{
			return GetByDNU_FirstPayRate(dNU_FirstPayRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayRate(decimal? dNU_FirstPayRate, int top_)
		{
			return GetByDNU_FirstPayRate(dNU_FirstPayRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayRate(decimal? dNU_FirstPayRate, int top_, TransactionManager tm_)
		{
			return GetByDNU_FirstPayRate(dNU_FirstPayRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayRate(decimal? dNU_FirstPayRate, string sort_)
		{
			return GetByDNU_FirstPayRate(dNU_FirstPayRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayRate(decimal? dNU_FirstPayRate, string sort_, TransactionManager tm_)
		{
			return GetByDNU_FirstPayRate(dNU_FirstPayRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayRate(decimal? dNU_FirstPayRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_FirstPayRate` = @DNU_FirstPayRate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_FirstPayRate", dNU_FirstPayRate.HasValue ? dNU_FirstPayRate.Value : (object)DBNull.Value, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_FirstPayRate
		#region GetByDNU_RepayRate
		
		/// <summary>
		/// 按 DNU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayRate"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayRate(decimal? dNU_RepayRate)
		{
			return GetByDNU_RepayRate(dNU_RepayRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayRate"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayRate(decimal? dNU_RepayRate, TransactionManager tm_)
		{
			return GetByDNU_RepayRate(dNU_RepayRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayRate(decimal? dNU_RepayRate, int top_)
		{
			return GetByDNU_RepayRate(dNU_RepayRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayRate(decimal? dNU_RepayRate, int top_, TransactionManager tm_)
		{
			return GetByDNU_RepayRate(dNU_RepayRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayRate(decimal? dNU_RepayRate, string sort_)
		{
			return GetByDNU_RepayRate(dNU_RepayRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayRate(decimal? dNU_RepayRate, string sort_, TransactionManager tm_)
		{
			return GetByDNU_RepayRate(dNU_RepayRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayRate(decimal? dNU_RepayRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_RepayRate` = @DNU_RepayRate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_RepayRate", dNU_RepayRate.HasValue ? dNU_RepayRate.Value : (object)DBNull.Value, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_RepayRate
		#region GetByDNU_RepayAmount
		
		/// <summary>
		/// 按 DNU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayAmount"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayAmount(long dNU_RepayAmount)
		{
			return GetByDNU_RepayAmount(dNU_RepayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayAmount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayAmount(long dNU_RepayAmount, TransactionManager tm_)
		{
			return GetByDNU_RepayAmount(dNU_RepayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayAmount(long dNU_RepayAmount, int top_)
		{
			return GetByDNU_RepayAmount(dNU_RepayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayAmount(long dNU_RepayAmount, int top_, TransactionManager tm_)
		{
			return GetByDNU_RepayAmount(dNU_RepayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayAmount(long dNU_RepayAmount, string sort_)
		{
			return GetByDNU_RepayAmount(dNU_RepayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayAmount(long dNU_RepayAmount, string sort_, TransactionManager tm_)
		{
			return GetByDNU_RepayAmount(dNU_RepayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayAmount(long dNU_RepayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_RepayAmount` = @DNU_RepayAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_RepayAmount", dNU_RepayAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_RepayAmount
		#region GetByDOU_FirstPayRate
		
		/// <summary>
		/// 按 DOU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayRate"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayRate(decimal? dOU_FirstPayRate)
		{
			return GetByDOU_FirstPayRate(dOU_FirstPayRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayRate"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayRate(decimal? dOU_FirstPayRate, TransactionManager tm_)
		{
			return GetByDOU_FirstPayRate(dOU_FirstPayRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayRate(decimal? dOU_FirstPayRate, int top_)
		{
			return GetByDOU_FirstPayRate(dOU_FirstPayRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayRate(decimal? dOU_FirstPayRate, int top_, TransactionManager tm_)
		{
			return GetByDOU_FirstPayRate(dOU_FirstPayRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayRate(decimal? dOU_FirstPayRate, string sort_)
		{
			return GetByDOU_FirstPayRate(dOU_FirstPayRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayRate(decimal? dOU_FirstPayRate, string sort_, TransactionManager tm_)
		{
			return GetByDOU_FirstPayRate(dOU_FirstPayRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayRate(decimal? dOU_FirstPayRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_FirstPayRate` = @DOU_FirstPayRate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_FirstPayRate", dOU_FirstPayRate.HasValue ? dOU_FirstPayRate.Value : (object)DBNull.Value, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_FirstPayRate
		#region GetByDOU_RepayUsers
		
		/// <summary>
		/// 按 DOU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayUsers"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayUsers(long dOU_RepayUsers)
		{
			return GetByDOU_RepayUsers(dOU_RepayUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayUsers"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayUsers(long dOU_RepayUsers, TransactionManager tm_)
		{
			return GetByDOU_RepayUsers(dOU_RepayUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayUsers(long dOU_RepayUsers, int top_)
		{
			return GetByDOU_RepayUsers(dOU_RepayUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayUsers(long dOU_RepayUsers, int top_, TransactionManager tm_)
		{
			return GetByDOU_RepayUsers(dOU_RepayUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayUsers"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayUsers(long dOU_RepayUsers, string sort_)
		{
			return GetByDOU_RepayUsers(dOU_RepayUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayUsers"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayUsers(long dOU_RepayUsers, string sort_, TransactionManager tm_)
		{
			return GetByDOU_RepayUsers(dOU_RepayUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayUsers(long dOU_RepayUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_RepayUsers` = @DOU_RepayUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_RepayUsers", dOU_RepayUsers, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_RepayUsers
		#region GetByDOU_RepayAmount
		
		/// <summary>
		/// 按 DOU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayAmount"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayAmount(long dOU_RepayAmount)
		{
			return GetByDOU_RepayAmount(dOU_RepayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayAmount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayAmount(long dOU_RepayAmount, TransactionManager tm_)
		{
			return GetByDOU_RepayAmount(dOU_RepayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayAmount(long dOU_RepayAmount, int top_)
		{
			return GetByDOU_RepayAmount(dOU_RepayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayAmount(long dOU_RepayAmount, int top_, TransactionManager tm_)
		{
			return GetByDOU_RepayAmount(dOU_RepayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayAmount(long dOU_RepayAmount, string sort_)
		{
			return GetByDOU_RepayAmount(dOU_RepayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayAmount(long dOU_RepayAmount, string sort_, TransactionManager tm_)
		{
			return GetByDOU_RepayAmount(dOU_RepayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_RepayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayAmount(long dOU_RepayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_RepayAmount` = @DOU_RepayAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_RepayAmount", dOU_RepayAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_RepayAmount
		#region GetByDOU_RepayRate
		
		/// <summary>
		/// 按 DOU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayRate"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayRate(decimal? dOU_RepayRate)
		{
			return GetByDOU_RepayRate(dOU_RepayRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayRate"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayRate(decimal? dOU_RepayRate, TransactionManager tm_)
		{
			return GetByDOU_RepayRate(dOU_RepayRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayRate(decimal? dOU_RepayRate, int top_)
		{
			return GetByDOU_RepayRate(dOU_RepayRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayRate(decimal? dOU_RepayRate, int top_, TransactionManager tm_)
		{
			return GetByDOU_RepayRate(dOU_RepayRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayRate(decimal? dOU_RepayRate, string sort_)
		{
			return GetByDOU_RepayRate(dOU_RepayRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayRate"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayRate(decimal? dOU_RepayRate, string sort_, TransactionManager tm_)
		{
			return GetByDOU_RepayRate(dOU_RepayRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_RepayRate（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_RepayRate"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_RepayRate(decimal? dOU_RepayRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_RepayRate` = @DOU_RepayRate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_RepayRate", dOU_RepayRate.HasValue ? dOU_RepayRate.Value : (object)DBNull.Value, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_RepayRate
		#region GetByBetUsers
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetUsers(int betUsers)
		{
			return GetByBetUsers(betUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetUsers(int betUsers, TransactionManager tm_)
		{
			return GetByBetUsers(betUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetUsers(int betUsers, int top_)
		{
			return GetByBetUsers(betUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetUsers(int betUsers, int top_, TransactionManager tm_)
		{
			return GetByBetUsers(betUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetUsers(int betUsers, string sort_)
		{
			return GetByBetUsers(betUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetUsers(int betUsers, string sort_, TransactionManager tm_)
		{
			return GetByBetUsers(betUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetUsers(int betUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetUsers` = @BetUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByBetUsers
		#region GetByNewBetUsers
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewBetUsers(int newBetUsers)
		{
			return GetByNewBetUsers(newBetUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewBetUsers(int newBetUsers, TransactionManager tm_)
		{
			return GetByNewBetUsers(newBetUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewBetUsers(int newBetUsers, int top_)
		{
			return GetByNewBetUsers(newBetUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewBetUsers(int newBetUsers, int top_, TransactionManager tm_)
		{
			return GetByNewBetUsers(newBetUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewBetUsers(int newBetUsers, string sort_)
		{
			return GetByNewBetUsers(newBetUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewBetUsers(int newBetUsers, string sort_, TransactionManager tm_)
		{
			return GetByNewBetUsers(newBetUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewBetUsers(int newBetUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewBetUsers` = @NewBetUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewBetUsers", newBetUsers, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewBetUsers
		#region GetByNewUserBetAmount
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetAmount(long newUserBetAmount)
		{
			return GetByNewUserBetAmount(newUserBetAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetAmount(long newUserBetAmount, TransactionManager tm_)
		{
			return GetByNewUserBetAmount(newUserBetAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetAmount(long newUserBetAmount, int top_)
		{
			return GetByNewUserBetAmount(newUserBetAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetAmount(long newUserBetAmount, int top_, TransactionManager tm_)
		{
			return GetByNewUserBetAmount(newUserBetAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetAmount(long newUserBetAmount, string sort_)
		{
			return GetByNewUserBetAmount(newUserBetAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetAmount(long newUserBetAmount, string sort_, TransactionManager tm_)
		{
			return GetByNewUserBetAmount(newUserBetAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetAmount(long newUserBetAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserBetAmount` = @NewUserBetAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewUserBetAmount", newUserBetAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewUserBetAmount
		#region GetByNewUserBetBonus
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetBonus(long newUserBetBonus)
		{
			return GetByNewUserBetBonus(newUserBetBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetBonus(long newUserBetBonus, TransactionManager tm_)
		{
			return GetByNewUserBetBonus(newUserBetBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetBonus(long newUserBetBonus, int top_)
		{
			return GetByNewUserBetBonus(newUserBetBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetBonus(long newUserBetBonus, int top_, TransactionManager tm_)
		{
			return GetByNewUserBetBonus(newUserBetBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetBonus(long newUserBetBonus, string sort_)
		{
			return GetByNewUserBetBonus(newUserBetBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetBonus(long newUserBetBonus, string sort_, TransactionManager tm_)
		{
			return GetByNewUserBetBonus(newUserBetBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetBonus(long newUserBetBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserBetBonus` = @NewUserBetBonus", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewUserBetBonus", newUserBetBonus, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewUserBetBonus
		#region GetByNewUserWinBonus
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinBonus(long newUserWinBonus)
		{
			return GetByNewUserWinBonus(newUserWinBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinBonus(long newUserWinBonus, TransactionManager tm_)
		{
			return GetByNewUserWinBonus(newUserWinBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinBonus(long newUserWinBonus, int top_)
		{
			return GetByNewUserWinBonus(newUserWinBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinBonus(long newUserWinBonus, int top_, TransactionManager tm_)
		{
			return GetByNewUserWinBonus(newUserWinBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinBonus(long newUserWinBonus, string sort_)
		{
			return GetByNewUserWinBonus(newUserWinBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinBonus(long newUserWinBonus, string sort_, TransactionManager tm_)
		{
			return GetByNewUserWinBonus(newUserWinBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinBonus(long newUserWinBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserWinBonus` = @NewUserWinBonus", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewUserWinBonus", newUserWinBonus, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewUserWinBonus
		#region GetByNewUserWinCash
		
		/// <summary>
		/// 按 NewUserWinCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinCash"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinCash(long newUserWinCash)
		{
			return GetByNewUserWinCash(newUserWinCash, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserWinCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinCash"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinCash(long newUserWinCash, TransactionManager tm_)
		{
			return GetByNewUserWinCash(newUserWinCash, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinCash(long newUserWinCash, int top_)
		{
			return GetByNewUserWinCash(newUserWinCash, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserWinCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinCash(long newUserWinCash, int top_, TransactionManager tm_)
		{
			return GetByNewUserWinCash(newUserWinCash, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinCash"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinCash(long newUserWinCash, string sort_)
		{
			return GetByNewUserWinCash(newUserWinCash, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserWinCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinCash"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinCash(long newUserWinCash, string sort_, TransactionManager tm_)
		{
			return GetByNewUserWinCash(newUserWinCash, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinCash(long newUserWinCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserWinCash` = @NewUserWinCash", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewUserWinCash", newUserWinCash, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewUserWinCash
		#region GetByNewUserBetCash
		
		/// <summary>
		/// 按 NewUserBetCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetCash"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetCash(long newUserBetCash)
		{
			return GetByNewUserBetCash(newUserBetCash, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserBetCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetCash"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetCash(long newUserBetCash, TransactionManager tm_)
		{
			return GetByNewUserBetCash(newUserBetCash, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetCash(long newUserBetCash, int top_)
		{
			return GetByNewUserBetCash(newUserBetCash, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserBetCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetCash(long newUserBetCash, int top_, TransactionManager tm_)
		{
			return GetByNewUserBetCash(newUserBetCash, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetCash"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetCash(long newUserBetCash, string sort_)
		{
			return GetByNewUserBetCash(newUserBetCash, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserBetCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetCash"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetCash(long newUserBetCash, string sort_, TransactionManager tm_)
		{
			return GetByNewUserBetCash(newUserBetCash, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetCash（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserBetCash(long newUserBetCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserBetCash` = @NewUserBetCash", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewUserBetCash", newUserBetCash, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewUserBetCash
		#region GetByDOU_WinBonus
		
		/// <summary>
		/// 按 DOU_WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinBonus"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinBonus(long dOU_WinBonus)
		{
			return GetByDOU_WinBonus(dOU_WinBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinBonus"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinBonus(long dOU_WinBonus, TransactionManager tm_)
		{
			return GetByDOU_WinBonus(dOU_WinBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinBonus"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinBonus(long dOU_WinBonus, int top_)
		{
			return GetByDOU_WinBonus(dOU_WinBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinBonus"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinBonus(long dOU_WinBonus, int top_, TransactionManager tm_)
		{
			return GetByDOU_WinBonus(dOU_WinBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinBonus"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinBonus(long dOU_WinBonus, string sort_)
		{
			return GetByDOU_WinBonus(dOU_WinBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinBonus"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinBonus(long dOU_WinBonus, string sort_, TransactionManager tm_)
		{
			return GetByDOU_WinBonus(dOU_WinBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinBonus"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinBonus(long dOU_WinBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_WinBonus` = @DOU_WinBonus", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_WinBonus", dOU_WinBonus, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_WinBonus
		#region GetByDOU_WinCash
		
		/// <summary>
		/// 按 DOU_WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinCash"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinCash(long dOU_WinCash)
		{
			return GetByDOU_WinCash(dOU_WinCash, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinCash"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinCash(long dOU_WinCash, TransactionManager tm_)
		{
			return GetByDOU_WinCash(dOU_WinCash, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinCash(long dOU_WinCash, int top_)
		{
			return GetByDOU_WinCash(dOU_WinCash, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinCash(long dOU_WinCash, int top_, TransactionManager tm_)
		{
			return GetByDOU_WinCash(dOU_WinCash, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinCash"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinCash(long dOU_WinCash, string sort_)
		{
			return GetByDOU_WinCash(dOU_WinCash, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinCash"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinCash(long dOU_WinCash, string sort_, TransactionManager tm_)
		{
			return GetByDOU_WinCash(dOU_WinCash, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_WinCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_WinCash(long dOU_WinCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_WinCash` = @DOU_WinCash", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_WinCash", dOU_WinCash, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_WinCash
		#region GetByTotalBalance
		
		/// <summary>
		/// 按 TotalBalance（字段） 查询
		/// </summary>
		/// /// <param name = "totalBalance">当日所有账户总存量</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalBalance(long totalBalance)
		{
			return GetByTotalBalance(totalBalance, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBalance（字段） 查询
		/// </summary>
		/// /// <param name = "totalBalance">当日所有账户总存量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalBalance(long totalBalance, TransactionManager tm_)
		{
			return GetByTotalBalance(totalBalance, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBalance（字段） 查询
		/// </summary>
		/// /// <param name = "totalBalance">当日所有账户总存量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalBalance(long totalBalance, int top_)
		{
			return GetByTotalBalance(totalBalance, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBalance（字段） 查询
		/// </summary>
		/// /// <param name = "totalBalance">当日所有账户总存量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalBalance(long totalBalance, int top_, TransactionManager tm_)
		{
			return GetByTotalBalance(totalBalance, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBalance（字段） 查询
		/// </summary>
		/// /// <param name = "totalBalance">当日所有账户总存量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalBalance(long totalBalance, string sort_)
		{
			return GetByTotalBalance(totalBalance, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalBalance（字段） 查询
		/// </summary>
		/// /// <param name = "totalBalance">当日所有账户总存量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalBalance(long totalBalance, string sort_, TransactionManager tm_)
		{
			return GetByTotalBalance(totalBalance, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalBalance（字段） 查询
		/// </summary>
		/// /// <param name = "totalBalance">当日所有账户总存量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalBalance(long totalBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBalance` = @TotalBalance", top_, sort_);
			var parameter_ = Database.CreateInParameter("@TotalBalance", totalBalance, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByTotalBalance
		#region GetByTotalCashAmount
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalCashAmount(long totalCashAmount)
		{
			return GetByTotalCashAmount(totalCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalCashAmount(long totalCashAmount, TransactionManager tm_)
		{
			return GetByTotalCashAmount(totalCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalCashAmount(long totalCashAmount, int top_)
		{
			return GetByTotalCashAmount(totalCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalCashAmount(long totalCashAmount, int top_, TransactionManager tm_)
		{
			return GetByTotalCashAmount(totalCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalCashAmount(long totalCashAmount, string sort_)
		{
			return GetByTotalCashAmount(totalCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalCashAmount(long totalCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByTotalCashAmount(totalCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByTotalCashAmount(long totalCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalCashAmount` = @TotalCashAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByTotalCashAmount
		#region GetByBetAmount
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注数量</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetAmount(long betAmount)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetAmount(long betAmount, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetAmount(long betAmount, int top_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetAmount(long betAmount, int top_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetAmount(long betAmount, string sort_)
		{
			return GetByBetAmount(betAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetAmount(long betAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetAmount(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByBetAmount
		#region GetByBetBonus
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetBonus(long betBonus)
		{
			return GetByBetBonus(betBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetBonus(long betBonus, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetBonus(long betBonus, int top_)
		{
			return GetByBetBonus(betBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetBonus(long betBonus, int top_, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetBonus(long betBonus, string sort_)
		{
			return GetByBetBonus(betBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetBonus(long betBonus, string sort_, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetBonus(long betBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonus` = @BetBonus", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByBetBonus
		#region GetByBetCash
		
		/// <summary>
		/// 按 BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "betCash"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetCash(long betCash)
		{
			return GetByBetCash(betCash, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "betCash"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetCash(long betCash, TransactionManager tm_)
		{
			return GetByBetCash(betCash, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "betCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetCash(long betCash, int top_)
		{
			return GetByBetCash(betCash, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "betCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetCash(long betCash, int top_, TransactionManager tm_)
		{
			return GetByBetCash(betCash, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "betCash"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetCash(long betCash, string sort_)
		{
			return GetByBetCash(betCash, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "betCash"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetCash(long betCash, string sort_, TransactionManager tm_)
		{
			return GetByBetCash(betCash, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetCash（字段） 查询
		/// </summary>
		/// /// <param name = "betCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetCash(long betCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCash` = @BetCash", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BetCash", betCash, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByBetCash
		#region GetByWinAmount
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖数量</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinAmount(long winAmount)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinAmount(long winAmount, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinAmount(long winAmount, int top_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinAmount(long winAmount, int top_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinAmount(long winAmount, string sort_)
		{
			return GetByWinAmount(winAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinAmount(long winAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinAmount(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByWinAmount
		#region GetByWinBonus
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinBonus(long winBonus)
		{
			return GetByWinBonus(winBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinBonus(long winBonus, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinBonus(long winBonus, int top_)
		{
			return GetByWinBonus(winBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinBonus(long winBonus, int top_, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinBonus(long winBonus, string sort_)
		{
			return GetByWinBonus(winBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinBonus(long winBonus, string sort_, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinBonus(long winBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonus` = @WinBonus", top_, sort_);
			var parameter_ = Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByWinBonus
		#region GetByWinCash
		
		/// <summary>
		/// 按 WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "winCash"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinCash(long winCash)
		{
			return GetByWinCash(winCash, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "winCash"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinCash(long winCash, TransactionManager tm_)
		{
			return GetByWinCash(winCash, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "winCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinCash(long winCash, int top_)
		{
			return GetByWinCash(winCash, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "winCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinCash(long winCash, int top_, TransactionManager tm_)
		{
			return GetByWinCash(winCash, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "winCash"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinCash(long winCash, string sort_)
		{
			return GetByWinCash(winCash, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "winCash"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinCash(long winCash, string sort_, TransactionManager tm_)
		{
			return GetByWinCash(winCash, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinCash（字段） 查询
		/// </summary>
		/// /// <param name = "winCash"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWinCash(long winCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCash` = @WinCash", top_, sort_);
			var parameter_ = Database.CreateInParameter("@WinCash", winCash, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByWinCash
		#region GetByPayUsers
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数PU</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUsers(int payUsers)
		{
			return GetByPayUsers(payUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数PU</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUsers(int payUsers, TransactionManager tm_)
		{
			return GetByPayUsers(payUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数PU</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUsers(int payUsers, int top_)
		{
			return GetByPayUsers(payUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数PU</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUsers(int payUsers, int top_, TransactionManager tm_)
		{
			return GetByPayUsers(payUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数PU</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUsers(int payUsers, string sort_)
		{
			return GetByPayUsers(payUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数PU</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUsers(int payUsers, string sort_, TransactionManager tm_)
		{
			return GetByPayUsers(payUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数PU</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUsers(int payUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayUsers` = @PayUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayUsers", payUsers, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayUsers
		#region GetByNewPayUsers
		
		/// <summary>
		/// 按 NewPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newPayUsers">新充值用户数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewPayUsers(int newPayUsers)
		{
			return GetByNewPayUsers(newPayUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newPayUsers">新充值用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewPayUsers(int newPayUsers, TransactionManager tm_)
		{
			return GetByNewPayUsers(newPayUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newPayUsers">新充值用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewPayUsers(int newPayUsers, int top_)
		{
			return GetByNewPayUsers(newPayUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newPayUsers">新充值用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewPayUsers(int newPayUsers, int top_, TransactionManager tm_)
		{
			return GetByNewPayUsers(newPayUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newPayUsers">新充值用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewPayUsers(int newPayUsers, string sort_)
		{
			return GetByNewPayUsers(newPayUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newPayUsers">新充值用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewPayUsers(int newPayUsers, string sort_, TransactionManager tm_)
		{
			return GetByNewPayUsers(newPayUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newPayUsers">新充值用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewPayUsers(int newPayUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewPayUsers` = @NewPayUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewPayUsers", newPayUsers, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewPayUsers
		#region GetByPayNotBetUsers
		
		/// <summary>
		/// 按 PayNotBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payNotBetUsers">充值未下注用户数量</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayNotBetUsers(int payNotBetUsers)
		{
			return GetByPayNotBetUsers(payNotBetUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayNotBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payNotBetUsers">充值未下注用户数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayNotBetUsers(int payNotBetUsers, TransactionManager tm_)
		{
			return GetByPayNotBetUsers(payNotBetUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayNotBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payNotBetUsers">充值未下注用户数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayNotBetUsers(int payNotBetUsers, int top_)
		{
			return GetByPayNotBetUsers(payNotBetUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayNotBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payNotBetUsers">充值未下注用户数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayNotBetUsers(int payNotBetUsers, int top_, TransactionManager tm_)
		{
			return GetByPayNotBetUsers(payNotBetUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayNotBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payNotBetUsers">充值未下注用户数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayNotBetUsers(int payNotBetUsers, string sort_)
		{
			return GetByPayNotBetUsers(payNotBetUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayNotBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payNotBetUsers">充值未下注用户数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayNotBetUsers(int payNotBetUsers, string sort_, TransactionManager tm_)
		{
			return GetByPayNotBetUsers(payNotBetUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayNotBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payNotBetUsers">充值未下注用户数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayNotBetUsers(int payNotBetUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayNotBetUsers` = @PayNotBetUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayNotBetUsers", payNotBetUsers, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayNotBetUsers
		#region GetByDOU_FirstPayUsers
		
		/// <summary>
		/// 按 DOU_FirstPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayUsers">当日首充(历史未充值)的老用户数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayUsers(int dOU_FirstPayUsers)
		{
			return GetByDOU_FirstPayUsers(dOU_FirstPayUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayUsers">当日首充(历史未充值)的老用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayUsers(int dOU_FirstPayUsers, TransactionManager tm_)
		{
			return GetByDOU_FirstPayUsers(dOU_FirstPayUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayUsers">当日首充(历史未充值)的老用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayUsers(int dOU_FirstPayUsers, int top_)
		{
			return GetByDOU_FirstPayUsers(dOU_FirstPayUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayUsers">当日首充(历史未充值)的老用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayUsers(int dOU_FirstPayUsers, int top_, TransactionManager tm_)
		{
			return GetByDOU_FirstPayUsers(dOU_FirstPayUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayUsers">当日首充(历史未充值)的老用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayUsers(int dOU_FirstPayUsers, string sort_)
		{
			return GetByDOU_FirstPayUsers(dOU_FirstPayUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayUsers">当日首充(历史未充值)的老用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayUsers(int dOU_FirstPayUsers, string sort_, TransactionManager tm_)
		{
			return GetByDOU_FirstPayUsers(dOU_FirstPayUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayUsers">当日首充(历史未充值)的老用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayUsers(int dOU_FirstPayUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_FirstPayUsers` = @DOU_FirstPayUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_FirstPayUsers", dOU_FirstPayUsers, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_FirstPayUsers
		#region GetByDNU_RepayUsers
		
		/// <summary>
		/// 按 DNU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayUsers">DNU复充用户数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayUsers(int dNU_RepayUsers)
		{
			return GetByDNU_RepayUsers(dNU_RepayUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayUsers">DNU复充用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayUsers(int dNU_RepayUsers, TransactionManager tm_)
		{
			return GetByDNU_RepayUsers(dNU_RepayUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayUsers">DNU复充用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayUsers(int dNU_RepayUsers, int top_)
		{
			return GetByDNU_RepayUsers(dNU_RepayUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayUsers">DNU复充用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayUsers(int dNU_RepayUsers, int top_, TransactionManager tm_)
		{
			return GetByDNU_RepayUsers(dNU_RepayUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayUsers">DNU复充用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayUsers(int dNU_RepayUsers, string sort_)
		{
			return GetByDNU_RepayUsers(dNU_RepayUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayUsers">DNU复充用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayUsers(int dNU_RepayUsers, string sort_, TransactionManager tm_)
		{
			return GetByDNU_RepayUsers(dNU_RepayUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_RepayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_RepayUsers">DNU复充用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_RepayUsers(int dNU_RepayUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_RepayUsers` = @DNU_RepayUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_RepayUsers", dNU_RepayUsers, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_RepayUsers
		#region GetByRepeatConsumersD1
		
		/// <summary>
		/// 按 RepeatConsumersD1（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD1">回流用户</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD1(int repeatConsumersD1)
		{
			return GetByRepeatConsumersD1(repeatConsumersD1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD1（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD1">回流用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD1(int repeatConsumersD1, TransactionManager tm_)
		{
			return GetByRepeatConsumersD1(repeatConsumersD1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD1（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD1">回流用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD1(int repeatConsumersD1, int top_)
		{
			return GetByRepeatConsumersD1(repeatConsumersD1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD1（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD1">回流用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD1(int repeatConsumersD1, int top_, TransactionManager tm_)
		{
			return GetByRepeatConsumersD1(repeatConsumersD1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD1（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD1">回流用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD1(int repeatConsumersD1, string sort_)
		{
			return GetByRepeatConsumersD1(repeatConsumersD1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD1（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD1">回流用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD1(int repeatConsumersD1, string sort_, TransactionManager tm_)
		{
			return GetByRepeatConsumersD1(repeatConsumersD1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD1（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD1">回流用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD1(int repeatConsumersD1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RepeatConsumersD1` = @RepeatConsumersD1", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RepeatConsumersD1", repeatConsumersD1, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRepeatConsumersD1
		#region GetByRepeatConsumersD5
		
		/// <summary>
		/// 按 RepeatConsumersD5（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD5">回流用户(5日）</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD5(int repeatConsumersD5)
		{
			return GetByRepeatConsumersD5(repeatConsumersD5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD5（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD5">回流用户(5日）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD5(int repeatConsumersD5, TransactionManager tm_)
		{
			return GetByRepeatConsumersD5(repeatConsumersD5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD5（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD5">回流用户(5日）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD5(int repeatConsumersD5, int top_)
		{
			return GetByRepeatConsumersD5(repeatConsumersD5, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD5（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD5">回流用户(5日）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD5(int repeatConsumersD5, int top_, TransactionManager tm_)
		{
			return GetByRepeatConsumersD5(repeatConsumersD5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD5（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD5">回流用户(5日）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD5(int repeatConsumersD5, string sort_)
		{
			return GetByRepeatConsumersD5(repeatConsumersD5, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD5（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD5">回流用户(5日）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD5(int repeatConsumersD5, string sort_, TransactionManager tm_)
		{
			return GetByRepeatConsumersD5(repeatConsumersD5, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD5（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD5">回流用户(5日）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD5(int repeatConsumersD5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RepeatConsumersD5` = @RepeatConsumersD5", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RepeatConsumersD5", repeatConsumersD5, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRepeatConsumersD5
		#region GetByRepeatConsumersD10
		
		/// <summary>
		/// 按 RepeatConsumersD10（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD10">回流用户(10日)</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD10(int repeatConsumersD10)
		{
			return GetByRepeatConsumersD10(repeatConsumersD10, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD10（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD10">回流用户(10日)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD10(int repeatConsumersD10, TransactionManager tm_)
		{
			return GetByRepeatConsumersD10(repeatConsumersD10, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD10（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD10">回流用户(10日)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD10(int repeatConsumersD10, int top_)
		{
			return GetByRepeatConsumersD10(repeatConsumersD10, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD10（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD10">回流用户(10日)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD10(int repeatConsumersD10, int top_, TransactionManager tm_)
		{
			return GetByRepeatConsumersD10(repeatConsumersD10, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD10（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD10">回流用户(10日)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD10(int repeatConsumersD10, string sort_)
		{
			return GetByRepeatConsumersD10(repeatConsumersD10, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD10（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD10">回流用户(10日)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD10(int repeatConsumersD10, string sort_, TransactionManager tm_)
		{
			return GetByRepeatConsumersD10(repeatConsumersD10, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD10（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD10">回流用户(10日)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD10(int repeatConsumersD10, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RepeatConsumersD10` = @RepeatConsumersD10", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RepeatConsumersD10", repeatConsumersD10, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRepeatConsumersD10
		#region GetByRepeatConsumersD15
		
		/// <summary>
		/// 按 RepeatConsumersD15（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD15">回流用户(15日)</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD15(int repeatConsumersD15)
		{
			return GetByRepeatConsumersD15(repeatConsumersD15, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD15（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD15">回流用户(15日)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD15(int repeatConsumersD15, TransactionManager tm_)
		{
			return GetByRepeatConsumersD15(repeatConsumersD15, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD15（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD15">回流用户(15日)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD15(int repeatConsumersD15, int top_)
		{
			return GetByRepeatConsumersD15(repeatConsumersD15, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD15（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD15">回流用户(15日)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD15(int repeatConsumersD15, int top_, TransactionManager tm_)
		{
			return GetByRepeatConsumersD15(repeatConsumersD15, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD15（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD15">回流用户(15日)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD15(int repeatConsumersD15, string sort_)
		{
			return GetByRepeatConsumersD15(repeatConsumersD15, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD15（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD15">回流用户(15日)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD15(int repeatConsumersD15, string sort_, TransactionManager tm_)
		{
			return GetByRepeatConsumersD15(repeatConsumersD15, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RepeatConsumersD15（字段） 查询
		/// </summary>
		/// /// <param name = "repeatConsumersD15">回流用户(15日)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRepeatConsumersD15(int repeatConsumersD15, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RepeatConsumersD15` = @RepeatConsumersD15", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RepeatConsumersD15", repeatConsumersD15, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRepeatConsumersD15
		#region GetByDNU_FirstPayAmount
		
		/// <summary>
		/// 按 DNU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayAmount">DNU首充金额</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayAmount(long dNU_FirstPayAmount)
		{
			return GetByDNU_FirstPayAmount(dNU_FirstPayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayAmount">DNU首充金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayAmount(long dNU_FirstPayAmount, TransactionManager tm_)
		{
			return GetByDNU_FirstPayAmount(dNU_FirstPayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayAmount">DNU首充金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayAmount(long dNU_FirstPayAmount, int top_)
		{
			return GetByDNU_FirstPayAmount(dNU_FirstPayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayAmount">DNU首充金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayAmount(long dNU_FirstPayAmount, int top_, TransactionManager tm_)
		{
			return GetByDNU_FirstPayAmount(dNU_FirstPayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayAmount">DNU首充金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayAmount(long dNU_FirstPayAmount, string sort_)
		{
			return GetByDNU_FirstPayAmount(dNU_FirstPayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayAmount">DNU首充金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayAmount(long dNU_FirstPayAmount, string sort_, TransactionManager tm_)
		{
			return GetByDNU_FirstPayAmount(dNU_FirstPayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_FirstPayAmount">DNU首充金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_FirstPayAmount(long dNU_FirstPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_FirstPayAmount` = @DNU_FirstPayAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_FirstPayAmount", dNU_FirstPayAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_FirstPayAmount
		#region GetByDOU_FirstPayAmount
		
		/// <summary>
		/// 按 DOU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayAmount">老用户当日首充的累计金额</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayAmount(long dOU_FirstPayAmount)
		{
			return GetByDOU_FirstPayAmount(dOU_FirstPayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayAmount">老用户当日首充的累计金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayAmount(long dOU_FirstPayAmount, TransactionManager tm_)
		{
			return GetByDOU_FirstPayAmount(dOU_FirstPayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayAmount">老用户当日首充的累计金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayAmount(long dOU_FirstPayAmount, int top_)
		{
			return GetByDOU_FirstPayAmount(dOU_FirstPayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayAmount">老用户当日首充的累计金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayAmount(long dOU_FirstPayAmount, int top_, TransactionManager tm_)
		{
			return GetByDOU_FirstPayAmount(dOU_FirstPayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayAmount">老用户当日首充的累计金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayAmount(long dOU_FirstPayAmount, string sort_)
		{
			return GetByDOU_FirstPayAmount(dOU_FirstPayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayAmount">老用户当日首充的累计金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayAmount(long dOU_FirstPayAmount, string sort_, TransactionManager tm_)
		{
			return GetByDOU_FirstPayAmount(dOU_FirstPayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_FirstPayAmount">老用户当日首充的累计金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_FirstPayAmount(long dOU_FirstPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_FirstPayAmount` = @DOU_FirstPayAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_FirstPayAmount", dOU_FirstPayAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_FirstPayAmount
		#region GetByPayOwnFee
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayOwnFee(decimal payOwnFee)
		{
			return GetByPayOwnFee(payOwnFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayOwnFee(decimal payOwnFee, TransactionManager tm_)
		{
			return GetByPayOwnFee(payOwnFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayOwnFee(decimal payOwnFee, int top_)
		{
			return GetByPayOwnFee(payOwnFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayOwnFee(decimal payOwnFee, int top_, TransactionManager tm_)
		{
			return GetByPayOwnFee(payOwnFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayOwnFee(decimal payOwnFee, string sort_)
		{
			return GetByPayOwnFee(payOwnFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayOwnFee(decimal payOwnFee, string sort_, TransactionManager tm_)
		{
			return GetByPayOwnFee(payOwnFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayOwnFee(decimal payOwnFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayOwnFee` = @PayOwnFee", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayOwnFee
		#region GetByPayUserFee
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUserFee(decimal payUserFee)
		{
			return GetByPayUserFee(payUserFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUserFee(decimal payUserFee, TransactionManager tm_)
		{
			return GetByPayUserFee(payUserFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUserFee(decimal payUserFee, int top_)
		{
			return GetByPayUserFee(payUserFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUserFee(decimal payUserFee, int top_, TransactionManager tm_)
		{
			return GetByPayUserFee(payUserFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUserFee(decimal payUserFee, string sort_)
		{
			return GetByPayUserFee(payUserFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUserFee(decimal payUserFee, string sort_, TransactionManager tm_)
		{
			return GetByPayUserFee(payUserFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayUserFee(decimal payUserFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayUserFee` = @PayUserFee", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayUserFee
		#region GetByNewUserPayAmount
		
		/// <summary>
		/// 按 NewUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserPayAmount">新用户充值额</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserPayAmount(long newUserPayAmount)
		{
			return GetByNewUserPayAmount(newUserPayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserPayAmount">新用户充值额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserPayAmount(long newUserPayAmount, TransactionManager tm_)
		{
			return GetByNewUserPayAmount(newUserPayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserPayAmount">新用户充值额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserPayAmount(long newUserPayAmount, int top_)
		{
			return GetByNewUserPayAmount(newUserPayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserPayAmount">新用户充值额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserPayAmount(long newUserPayAmount, int top_, TransactionManager tm_)
		{
			return GetByNewUserPayAmount(newUserPayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserPayAmount">新用户充值额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserPayAmount(long newUserPayAmount, string sort_)
		{
			return GetByNewUserPayAmount(newUserPayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserPayAmount">新用户充值额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserPayAmount(long newUserPayAmount, string sort_, TransactionManager tm_)
		{
			return GetByNewUserPayAmount(newUserPayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserPayAmount">新用户充值额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserPayAmount(long newUserPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserPayAmount` = @NewUserPayAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewUserPayAmount", newUserPayAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewUserPayAmount
		#region GetByPayAmount
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayAmount(long payAmount)
		{
			return GetByPayAmount(payAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayAmount(long payAmount, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayAmount(long payAmount, int top_)
		{
			return GetByPayAmount(payAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayAmount(long payAmount, int top_, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayAmount(long payAmount, string sort_)
		{
			return GetByPayAmount(payAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayAmount(long payAmount, string sort_, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayAmount(long payAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmount` = @PayAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayAmount
		#region GetByCashUsers
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUsers(int cashUsers)
		{
			return GetByCashUsers(cashUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUsers(int cashUsers, TransactionManager tm_)
		{
			return GetByCashUsers(cashUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUsers(int cashUsers, int top_)
		{
			return GetByCashUsers(cashUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUsers(int cashUsers, int top_, TransactionManager tm_)
		{
			return GetByCashUsers(cashUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUsers(int cashUsers, string sort_)
		{
			return GetByCashUsers(cashUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUsers(int cashUsers, string sort_, TransactionManager tm_)
		{
			return GetByCashUsers(cashUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUsers(int cashUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashUsers` = @CashUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CashUsers", cashUsers, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByCashUsers
		#region GetByNewCashUsers
		
		/// <summary>
		/// 按 NewCashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newCashUsers">新提现用户数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewCashUsers(int newCashUsers)
		{
			return GetByNewCashUsers(newCashUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewCashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newCashUsers">新提现用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewCashUsers(int newCashUsers, TransactionManager tm_)
		{
			return GetByNewCashUsers(newCashUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewCashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newCashUsers">新提现用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewCashUsers(int newCashUsers, int top_)
		{
			return GetByNewCashUsers(newCashUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewCashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newCashUsers">新提现用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewCashUsers(int newCashUsers, int top_, TransactionManager tm_)
		{
			return GetByNewCashUsers(newCashUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewCashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newCashUsers">新提现用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewCashUsers(int newCashUsers, string sort_)
		{
			return GetByNewCashUsers(newCashUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewCashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newCashUsers">新提现用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewCashUsers(int newCashUsers, string sort_, TransactionManager tm_)
		{
			return GetByNewCashUsers(newCashUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewCashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newCashUsers">新提现用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewCashUsers(int newCashUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewCashUsers` = @NewCashUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewCashUsers", newCashUsers, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewCashUsers
		#region GetByDOU_CashUsers
		
		/// <summary>
		/// 按 DOU_CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_CashUsers"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_CashUsers(long dOU_CashUsers)
		{
			return GetByDOU_CashUsers(dOU_CashUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_CashUsers"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_CashUsers(long dOU_CashUsers, TransactionManager tm_)
		{
			return GetByDOU_CashUsers(dOU_CashUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_CashUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_CashUsers(long dOU_CashUsers, int top_)
		{
			return GetByDOU_CashUsers(dOU_CashUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DOU_CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_CashUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_CashUsers(long dOU_CashUsers, int top_, TransactionManager tm_)
		{
			return GetByDOU_CashUsers(dOU_CashUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DOU_CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_CashUsers"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_CashUsers(long dOU_CashUsers, string sort_)
		{
			return GetByDOU_CashUsers(dOU_CashUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DOU_CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_CashUsers"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_CashUsers(long dOU_CashUsers, string sort_, TransactionManager tm_)
		{
			return GetByDOU_CashUsers(dOU_CashUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DOU_CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "dOU_CashUsers"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDOU_CashUsers(long dOU_CashUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DOU_CashUsers` = @DOU_CashUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DOU_CashUsers", dOU_CashUsers, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDOU_CashUsers
		#region GetByCashOwnFee
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashOwnFee(decimal cashOwnFee)
		{
			return GetByCashOwnFee(cashOwnFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashOwnFee(decimal cashOwnFee, TransactionManager tm_)
		{
			return GetByCashOwnFee(cashOwnFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashOwnFee(decimal cashOwnFee, int top_)
		{
			return GetByCashOwnFee(cashOwnFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashOwnFee(decimal cashOwnFee, int top_, TransactionManager tm_)
		{
			return GetByCashOwnFee(cashOwnFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashOwnFee(decimal cashOwnFee, string sort_)
		{
			return GetByCashOwnFee(cashOwnFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashOwnFee(decimal cashOwnFee, string sort_, TransactionManager tm_)
		{
			return GetByCashOwnFee(cashOwnFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashOwnFee(decimal cashOwnFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashOwnFee` = @CashOwnFee", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CashOwnFee", cashOwnFee, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByCashOwnFee
		#region GetByCashUserFee
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUserFee(decimal cashUserFee)
		{
			return GetByCashUserFee(cashUserFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUserFee(decimal cashUserFee, TransactionManager tm_)
		{
			return GetByCashUserFee(cashUserFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUserFee(decimal cashUserFee, int top_)
		{
			return GetByCashUserFee(cashUserFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUserFee(decimal cashUserFee, int top_, TransactionManager tm_)
		{
			return GetByCashUserFee(cashUserFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUserFee(decimal cashUserFee, string sort_)
		{
			return GetByCashUserFee(cashUserFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUserFee(decimal cashUserFee, string sort_, TransactionManager tm_)
		{
			return GetByCashUserFee(cashUserFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashUserFee(decimal cashUserFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashUserFee` = @CashUserFee", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByCashUserFee
		#region GetByNewUserCashAmount
		
		/// <summary>
		/// 按 NewUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserCashAmount">新用户提现额</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserCashAmount(long newUserCashAmount)
		{
			return GetByNewUserCashAmount(newUserCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserCashAmount">新用户提现额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserCashAmount(long newUserCashAmount, TransactionManager tm_)
		{
			return GetByNewUserCashAmount(newUserCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserCashAmount">新用户提现额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserCashAmount(long newUserCashAmount, int top_)
		{
			return GetByNewUserCashAmount(newUserCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserCashAmount">新用户提现额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserCashAmount(long newUserCashAmount, int top_, TransactionManager tm_)
		{
			return GetByNewUserCashAmount(newUserCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserCashAmount">新用户提现额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserCashAmount(long newUserCashAmount, string sort_)
		{
			return GetByNewUserCashAmount(newUserCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserCashAmount">新用户提现额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserCashAmount(long newUserCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByNewUserCashAmount(newUserCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserCashAmount">新用户提现额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserCashAmount(long newUserCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserCashAmount` = @NewUserCashAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewUserCashAmount", newUserCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewUserCashAmount
		#region GetByNewUserWinAmount
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinAmount(long newUserWinAmount)
		{
			return GetByNewUserWinAmount(newUserWinAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinAmount(long newUserWinAmount, TransactionManager tm_)
		{
			return GetByNewUserWinAmount(newUserWinAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinAmount(long newUserWinAmount, int top_)
		{
			return GetByNewUserWinAmount(newUserWinAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinAmount(long newUserWinAmount, int top_, TransactionManager tm_)
		{
			return GetByNewUserWinAmount(newUserWinAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinAmount(long newUserWinAmount, string sort_)
		{
			return GetByNewUserWinAmount(newUserWinAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinAmount(long newUserWinAmount, string sort_, TransactionManager tm_)
		{
			return GetByNewUserWinAmount(newUserWinAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewUserWinAmount(long newUserWinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserWinAmount` = @NewUserWinAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewUserWinAmount", newUserWinAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewUserWinAmount
		#region GetByCashAmount
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAmount(long cashAmount)
		{
			return GetByCashAmount(cashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAmount(long cashAmount, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAmount(long cashAmount, int top_)
		{
			return GetByCashAmount(cashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAmount(long cashAmount, int top_, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAmount(long cashAmount, string sort_)
		{
			return GetByCashAmount(cashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAmount(long cashAmount, string sort_, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAmount(long cashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAmount` = @CashAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByCashAmount
		#region GetByBonusRecUsers
		
		/// <summary>
		/// 按 BonusRecUsers（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRecUsers">bonus领取人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRecUsers(long bonusRecUsers)
		{
			return GetByBonusRecUsers(bonusRecUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusRecUsers（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRecUsers">bonus领取人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRecUsers(long bonusRecUsers, TransactionManager tm_)
		{
			return GetByBonusRecUsers(bonusRecUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusRecUsers（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRecUsers">bonus领取人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRecUsers(long bonusRecUsers, int top_)
		{
			return GetByBonusRecUsers(bonusRecUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusRecUsers（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRecUsers">bonus领取人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRecUsers(long bonusRecUsers, int top_, TransactionManager tm_)
		{
			return GetByBonusRecUsers(bonusRecUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusRecUsers（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRecUsers">bonus领取人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRecUsers(long bonusRecUsers, string sort_)
		{
			return GetByBonusRecUsers(bonusRecUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BonusRecUsers（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRecUsers">bonus领取人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRecUsers(long bonusRecUsers, string sort_, TransactionManager tm_)
		{
			return GetByBonusRecUsers(bonusRecUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BonusRecUsers（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRecUsers">bonus领取人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRecUsers(long bonusRecUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusRecUsers` = @BonusRecUsers", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BonusRecUsers", bonusRecUsers, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByBonusRecUsers
		#region GetByBonusAmount
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">bonus发放总量</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusAmount(long bonusAmount)
		{
			return GetByBonusAmount(bonusAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">bonus发放总量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusAmount(long bonusAmount, TransactionManager tm_)
		{
			return GetByBonusAmount(bonusAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">bonus发放总量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusAmount(long bonusAmount, int top_)
		{
			return GetByBonusAmount(bonusAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">bonus发放总量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusAmount(long bonusAmount, int top_, TransactionManager tm_)
		{
			return GetByBonusAmount(bonusAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">bonus发放总量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusAmount(long bonusAmount, string sort_)
		{
			return GetByBonusAmount(bonusAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">bonus发放总量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusAmount(long bonusAmount, string sort_, TransactionManager tm_)
		{
			return GetByBonusAmount(bonusAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">bonus发放总量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusAmount(long bonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusAmount` = @BonusAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BonusAmount", bonusAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByBonusAmount
		#region GetByBonusUseAmount
		
		/// <summary>
		/// 按 BonusUseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUseAmount">bonus消耗总量</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUseAmount(long bonusUseAmount)
		{
			return GetByBonusUseAmount(bonusUseAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusUseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUseAmount">bonus消耗总量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUseAmount(long bonusUseAmount, TransactionManager tm_)
		{
			return GetByBonusUseAmount(bonusUseAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusUseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUseAmount">bonus消耗总量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUseAmount(long bonusUseAmount, int top_)
		{
			return GetByBonusUseAmount(bonusUseAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusUseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUseAmount">bonus消耗总量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUseAmount(long bonusUseAmount, int top_, TransactionManager tm_)
		{
			return GetByBonusUseAmount(bonusUseAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusUseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUseAmount">bonus消耗总量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUseAmount(long bonusUseAmount, string sort_)
		{
			return GetByBonusUseAmount(bonusUseAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BonusUseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUseAmount">bonus消耗总量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUseAmount(long bonusUseAmount, string sort_, TransactionManager tm_)
		{
			return GetByBonusUseAmount(bonusUseAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BonusUseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUseAmount">bonus消耗总量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUseAmount(long bonusUseAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusUseAmount` = @BonusUseAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BonusUseAmount", bonusUseAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByBonusUseAmount
		#region GetByBonusRemainAmount
		
		/// <summary>
		/// 按 BonusRemainAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRemainAmount">bonus存量</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRemainAmount(long bonusRemainAmount)
		{
			return GetByBonusRemainAmount(bonusRemainAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusRemainAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRemainAmount">bonus存量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRemainAmount(long bonusRemainAmount, TransactionManager tm_)
		{
			return GetByBonusRemainAmount(bonusRemainAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusRemainAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRemainAmount">bonus存量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRemainAmount(long bonusRemainAmount, int top_)
		{
			return GetByBonusRemainAmount(bonusRemainAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusRemainAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRemainAmount">bonus存量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRemainAmount(long bonusRemainAmount, int top_, TransactionManager tm_)
		{
			return GetByBonusRemainAmount(bonusRemainAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusRemainAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRemainAmount">bonus存量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRemainAmount(long bonusRemainAmount, string sort_)
		{
			return GetByBonusRemainAmount(bonusRemainAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BonusRemainAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRemainAmount">bonus存量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRemainAmount(long bonusRemainAmount, string sort_, TransactionManager tm_)
		{
			return GetByBonusRemainAmount(bonusRemainAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BonusRemainAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusRemainAmount">bonus存量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusRemainAmount(long bonusRemainAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusRemainAmount` = @BonusRemainAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BonusRemainAmount", bonusRemainAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByBonusRemainAmount
		#region GetByBonusUnlockAmount
		
		/// <summary>
		/// 按 BonusUnlockAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUnlockAmount">bonus解锁金额</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUnlockAmount(long bonusUnlockAmount)
		{
			return GetByBonusUnlockAmount(bonusUnlockAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusUnlockAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUnlockAmount">bonus解锁金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUnlockAmount(long bonusUnlockAmount, TransactionManager tm_)
		{
			return GetByBonusUnlockAmount(bonusUnlockAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusUnlockAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUnlockAmount">bonus解锁金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUnlockAmount(long bonusUnlockAmount, int top_)
		{
			return GetByBonusUnlockAmount(bonusUnlockAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusUnlockAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUnlockAmount">bonus解锁金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUnlockAmount(long bonusUnlockAmount, int top_, TransactionManager tm_)
		{
			return GetByBonusUnlockAmount(bonusUnlockAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusUnlockAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUnlockAmount">bonus解锁金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUnlockAmount(long bonusUnlockAmount, string sort_)
		{
			return GetByBonusUnlockAmount(bonusUnlockAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BonusUnlockAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUnlockAmount">bonus解锁金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUnlockAmount(long bonusUnlockAmount, string sort_, TransactionManager tm_)
		{
			return GetByBonusUnlockAmount(bonusUnlockAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BonusUnlockAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusUnlockAmount">bonus解锁金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBonusUnlockAmount(long bonusUnlockAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusUnlockAmount` = @BonusUnlockAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BonusUnlockAmount", bonusUnlockAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByBonusUnlockAmount
		#region GetByCashAuditAmount
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提审现金额度</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAuditAmount(long cashAuditAmount)
		{
			return GetByCashAuditAmount(cashAuditAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提审现金额度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAuditAmount(long cashAuditAmount, TransactionManager tm_)
		{
			return GetByCashAuditAmount(cashAuditAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提审现金额度</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAuditAmount(long cashAuditAmount, int top_)
		{
			return GetByCashAuditAmount(cashAuditAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提审现金额度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAuditAmount(long cashAuditAmount, int top_, TransactionManager tm_)
		{
			return GetByCashAuditAmount(cashAuditAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提审现金额度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAuditAmount(long cashAuditAmount, string sort_)
		{
			return GetByCashAuditAmount(cashAuditAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提审现金额度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAuditAmount(long cashAuditAmount, string sort_, TransactionManager tm_)
		{
			return GetByCashAuditAmount(cashAuditAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashAuditAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAuditAmount">提审现金额度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashAuditAmount(long cashAuditAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAuditAmount` = @CashAuditAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CashAuditAmount", cashAuditAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByCashAuditAmount
		#region GetByCashRefuseAmount
		
		/// <summary>
		/// 按 CashRefuseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashRefuseAmount">拒审现金额度</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashRefuseAmount(long cashRefuseAmount)
		{
			return GetByCashRefuseAmount(cashRefuseAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashRefuseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashRefuseAmount">拒审现金额度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashRefuseAmount(long cashRefuseAmount, TransactionManager tm_)
		{
			return GetByCashRefuseAmount(cashRefuseAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashRefuseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashRefuseAmount">拒审现金额度</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashRefuseAmount(long cashRefuseAmount, int top_)
		{
			return GetByCashRefuseAmount(cashRefuseAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashRefuseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashRefuseAmount">拒审现金额度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashRefuseAmount(long cashRefuseAmount, int top_, TransactionManager tm_)
		{
			return GetByCashRefuseAmount(cashRefuseAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashRefuseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashRefuseAmount">拒审现金额度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashRefuseAmount(long cashRefuseAmount, string sort_)
		{
			return GetByCashRefuseAmount(cashRefuseAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashRefuseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashRefuseAmount">拒审现金额度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashRefuseAmount(long cashRefuseAmount, string sort_, TransactionManager tm_)
		{
			return GetByCashRefuseAmount(cashRefuseAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashRefuseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashRefuseAmount">拒审现金额度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashRefuseAmount(long cashRefuseAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashRefuseAmount` = @CashRefuseAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CashRefuseAmount", cashRefuseAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByCashRefuseAmount
		#region GetByCashPassAmount
		
		/// <summary>
		/// 按 CashPassAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashPassAmount">通过现金额度</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashPassAmount(long cashPassAmount)
		{
			return GetByCashPassAmount(cashPassAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashPassAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashPassAmount">通过现金额度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashPassAmount(long cashPassAmount, TransactionManager tm_)
		{
			return GetByCashPassAmount(cashPassAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashPassAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashPassAmount">通过现金额度</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashPassAmount(long cashPassAmount, int top_)
		{
			return GetByCashPassAmount(cashPassAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashPassAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashPassAmount">通过现金额度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashPassAmount(long cashPassAmount, int top_, TransactionManager tm_)
		{
			return GetByCashPassAmount(cashPassAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashPassAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashPassAmount">通过现金额度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashPassAmount(long cashPassAmount, string sort_)
		{
			return GetByCashPassAmount(cashPassAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashPassAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashPassAmount">通过现金额度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashPassAmount(long cashPassAmount, string sort_, TransactionManager tm_)
		{
			return GetByCashPassAmount(cashPassAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashPassAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashPassAmount">通过现金额度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashPassAmount(long cashPassAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashPassAmount` = @CashPassAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CashPassAmount", cashPassAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByCashPassAmount
		#region GetByCashFailAmount
		
		/// <summary>
		/// 按 CashFailAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashFailAmount">失败金额</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashFailAmount(long cashFailAmount)
		{
			return GetByCashFailAmount(cashFailAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashFailAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashFailAmount">失败金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashFailAmount(long cashFailAmount, TransactionManager tm_)
		{
			return GetByCashFailAmount(cashFailAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashFailAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashFailAmount">失败金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashFailAmount(long cashFailAmount, int top_)
		{
			return GetByCashFailAmount(cashFailAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashFailAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashFailAmount">失败金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashFailAmount(long cashFailAmount, int top_, TransactionManager tm_)
		{
			return GetByCashFailAmount(cashFailAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashFailAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashFailAmount">失败金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashFailAmount(long cashFailAmount, string sort_)
		{
			return GetByCashFailAmount(cashFailAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashFailAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashFailAmount">失败金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashFailAmount(long cashFailAmount, string sort_, TransactionManager tm_)
		{
			return GetByCashFailAmount(cashFailAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashFailAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashFailAmount">失败金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByCashFailAmount(long cashFailAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashFailAmount` = @CashFailAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CashFailAmount", cashFailAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByCashFailAmount
		#region GetByProfitAmount
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">盈利数量GGR（下注-返奖-活动）</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByProfitAmount(long profitAmount)
		{
			return GetByProfitAmount(profitAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">盈利数量GGR（下注-返奖-活动）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByProfitAmount(long profitAmount, TransactionManager tm_)
		{
			return GetByProfitAmount(profitAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">盈利数量GGR（下注-返奖-活动）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByProfitAmount(long profitAmount, int top_)
		{
			return GetByProfitAmount(profitAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">盈利数量GGR（下注-返奖-活动）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByProfitAmount(long profitAmount, int top_, TransactionManager tm_)
		{
			return GetByProfitAmount(profitAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">盈利数量GGR（下注-返奖-活动）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByProfitAmount(long profitAmount, string sort_)
		{
			return GetByProfitAmount(profitAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">盈利数量GGR（下注-返奖-活动）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByProfitAmount(long profitAmount, string sort_, TransactionManager tm_)
		{
			return GetByProfitAmount(profitAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">盈利数量GGR（下注-返奖-活动）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByProfitAmount(long profitAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ProfitAmount` = @ProfitAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ProfitAmount", profitAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByProfitAmount
		#region GetByPromotionFeeAmount
		
		/// <summary>
		/// 按 PromotionFeeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "promotionFeeAmount">活动成本sum（s_currency_change.Amount）</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPromotionFeeAmount(long promotionFeeAmount)
		{
			return GetByPromotionFeeAmount(promotionFeeAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromotionFeeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "promotionFeeAmount">活动成本sum（s_currency_change.Amount）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPromotionFeeAmount(long promotionFeeAmount, TransactionManager tm_)
		{
			return GetByPromotionFeeAmount(promotionFeeAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromotionFeeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "promotionFeeAmount">活动成本sum（s_currency_change.Amount）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPromotionFeeAmount(long promotionFeeAmount, int top_)
		{
			return GetByPromotionFeeAmount(promotionFeeAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromotionFeeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "promotionFeeAmount">活动成本sum（s_currency_change.Amount）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPromotionFeeAmount(long promotionFeeAmount, int top_, TransactionManager tm_)
		{
			return GetByPromotionFeeAmount(promotionFeeAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromotionFeeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "promotionFeeAmount">活动成本sum（s_currency_change.Amount）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPromotionFeeAmount(long promotionFeeAmount, string sort_)
		{
			return GetByPromotionFeeAmount(promotionFeeAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PromotionFeeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "promotionFeeAmount">活动成本sum（s_currency_change.Amount）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPromotionFeeAmount(long promotionFeeAmount, string sort_, TransactionManager tm_)
		{
			return GetByPromotionFeeAmount(promotionFeeAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PromotionFeeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "promotionFeeAmount">活动成本sum（s_currency_change.Amount）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPromotionFeeAmount(long promotionFeeAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromotionFeeAmount` = @PromotionFeeAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PromotionFeeAmount", promotionFeeAmount, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPromotionFeeAmount
		#region GetByNewARUP
		
		/// <summary>
		/// 按 NewARUP（字段） 查询
		/// </summary>
		/// /// <param name = "newARUP">新用户ARUP（新下注用户数/新用户下注-返奖总额）</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewARUP(float newARUP)
		{
			return GetByNewARUP(newARUP, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewARUP（字段） 查询
		/// </summary>
		/// /// <param name = "newARUP">新用户ARUP（新下注用户数/新用户下注-返奖总额）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewARUP(float newARUP, TransactionManager tm_)
		{
			return GetByNewARUP(newARUP, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewARUP（字段） 查询
		/// </summary>
		/// /// <param name = "newARUP">新用户ARUP（新下注用户数/新用户下注-返奖总额）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewARUP(float newARUP, int top_)
		{
			return GetByNewARUP(newARUP, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewARUP（字段） 查询
		/// </summary>
		/// /// <param name = "newARUP">新用户ARUP（新下注用户数/新用户下注-返奖总额）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewARUP(float newARUP, int top_, TransactionManager tm_)
		{
			return GetByNewARUP(newARUP, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewARUP（字段） 查询
		/// </summary>
		/// /// <param name = "newARUP">新用户ARUP（新下注用户数/新用户下注-返奖总额）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewARUP(float newARUP, string sort_)
		{
			return GetByNewARUP(newARUP, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewARUP（字段） 查询
		/// </summary>
		/// /// <param name = "newARUP">新用户ARUP（新下注用户数/新用户下注-返奖总额）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewARUP(float newARUP, string sort_, TransactionManager tm_)
		{
			return GetByNewARUP(newARUP, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewARUP（字段） 查询
		/// </summary>
		/// /// <param name = "newARUP">新用户ARUP（新下注用户数/新用户下注-返奖总额）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByNewARUP(float newARUP, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewARUP` = @NewARUP", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NewARUP", newARUP, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByNewARUP
		#region GetByARUP
		
		/// <summary>
		/// 按 ARUP（字段） 查询
		/// </summary>
		/// /// <param name = "aRUP">ARUP</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByARUP(float aRUP)
		{
			return GetByARUP(aRUP, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ARUP（字段） 查询
		/// </summary>
		/// /// <param name = "aRUP">ARUP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByARUP(float aRUP, TransactionManager tm_)
		{
			return GetByARUP(aRUP, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ARUP（字段） 查询
		/// </summary>
		/// /// <param name = "aRUP">ARUP</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByARUP(float aRUP, int top_)
		{
			return GetByARUP(aRUP, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ARUP（字段） 查询
		/// </summary>
		/// /// <param name = "aRUP">ARUP</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByARUP(float aRUP, int top_, TransactionManager tm_)
		{
			return GetByARUP(aRUP, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ARUP（字段） 查询
		/// </summary>
		/// /// <param name = "aRUP">ARUP</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByARUP(float aRUP, string sort_)
		{
			return GetByARUP(aRUP, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ARUP（字段） 查询
		/// </summary>
		/// /// <param name = "aRUP">ARUP</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByARUP(float aRUP, string sort_, TransactionManager tm_)
		{
			return GetByARUP(aRUP, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ARUP（字段） 查询
		/// </summary>
		/// /// <param name = "aRUP">ARUP</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByARUP(float aRUP, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ARUP` = @ARUP", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ARUP", aRUP, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByARUP
		#region GetByArppu
		
		/// <summary>
		/// 按 Arppu（字段） 查询
		/// </summary>
		/// /// <param name = "arppu"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByArppu(decimal? arppu)
		{
			return GetByArppu(arppu, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Arppu（字段） 查询
		/// </summary>
		/// /// <param name = "arppu"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByArppu(decimal? arppu, TransactionManager tm_)
		{
			return GetByArppu(arppu, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Arppu（字段） 查询
		/// </summary>
		/// /// <param name = "arppu"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByArppu(decimal? arppu, int top_)
		{
			return GetByArppu(arppu, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Arppu（字段） 查询
		/// </summary>
		/// /// <param name = "arppu"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByArppu(decimal? arppu, int top_, TransactionManager tm_)
		{
			return GetByArppu(arppu, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Arppu（字段） 查询
		/// </summary>
		/// /// <param name = "arppu"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByArppu(decimal? arppu, string sort_)
		{
			return GetByArppu(arppu, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Arppu（字段） 查询
		/// </summary>
		/// /// <param name = "arppu"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByArppu(decimal? arppu, string sort_, TransactionManager tm_)
		{
			return GetByArppu(arppu, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Arppu（字段） 查询
		/// </summary>
		/// /// <param name = "arppu"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByArppu(decimal? arppu, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Arppu` = @Arppu", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Arppu", arppu.HasValue ? arppu.Value : (object)DBNull.Value, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByArppu
		#region GetByDNU_arppu
		
		/// <summary>
		/// 按 DNU_arppu（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_arppu"></param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_arppu(decimal? dNU_arppu)
		{
			return GetByDNU_arppu(dNU_arppu, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_arppu（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_arppu"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_arppu(decimal? dNU_arppu, TransactionManager tm_)
		{
			return GetByDNU_arppu(dNU_arppu, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_arppu（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_arppu"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_arppu(decimal? dNU_arppu, int top_)
		{
			return GetByDNU_arppu(dNU_arppu, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_arppu（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_arppu"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_arppu(decimal? dNU_arppu, int top_, TransactionManager tm_)
		{
			return GetByDNU_arppu(dNU_arppu, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_arppu（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_arppu"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_arppu(decimal? dNU_arppu, string sort_)
		{
			return GetByDNU_arppu(dNU_arppu, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_arppu（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_arppu"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_arppu(decimal? dNU_arppu, string sort_, TransactionManager tm_)
		{
			return GetByDNU_arppu(dNU_arppu, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_arppu（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_arppu"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_arppu(decimal? dNU_arppu, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_arppu` = @DNU_arppu", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_arppu", dNU_arppu.HasValue ? dNU_arppu.Value : (object)DBNull.Value, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_arppu
		#region GetByRetentionD1
		
		/// <summary>
		/// 按 RetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD1">1日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD1(float retentionD1)
		{
			return GetByRetentionD1(retentionD1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD1">1日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD1(float retentionD1, TransactionManager tm_)
		{
			return GetByRetentionD1(retentionD1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD1">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD1(float retentionD1, int top_)
		{
			return GetByRetentionD1(retentionD1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD1">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD1(float retentionD1, int top_, TransactionManager tm_)
		{
			return GetByRetentionD1(retentionD1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD1">1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD1(float retentionD1, string sort_)
		{
			return GetByRetentionD1(retentionD1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD1">1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD1(float retentionD1, string sort_, TransactionManager tm_)
		{
			return GetByRetentionD1(retentionD1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD1">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD1(float retentionD1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RetentionD1` = @RetentionD1", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RetentionD1", retentionD1, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRetentionD1
		#region GetByRetentionD3
		
		/// <summary>
		/// 按 RetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD3">3日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD3(float retentionD3)
		{
			return GetByRetentionD3(retentionD3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD3">3日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD3(float retentionD3, TransactionManager tm_)
		{
			return GetByRetentionD3(retentionD3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD3">3日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD3(float retentionD3, int top_)
		{
			return GetByRetentionD3(retentionD3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD3">3日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD3(float retentionD3, int top_, TransactionManager tm_)
		{
			return GetByRetentionD3(retentionD3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD3">3日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD3(float retentionD3, string sort_)
		{
			return GetByRetentionD3(retentionD3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD3">3日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD3(float retentionD3, string sort_, TransactionManager tm_)
		{
			return GetByRetentionD3(retentionD3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD3">3日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD3(float retentionD3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RetentionD3` = @RetentionD3", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RetentionD3", retentionD3, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRetentionD3
		#region GetByRetentionD7
		
		/// <summary>
		/// 按 RetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD7">7日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD7(float retentionD7)
		{
			return GetByRetentionD7(retentionD7, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD7">7日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD7(float retentionD7, TransactionManager tm_)
		{
			return GetByRetentionD7(retentionD7, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD7">7日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD7(float retentionD7, int top_)
		{
			return GetByRetentionD7(retentionD7, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD7">7日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD7(float retentionD7, int top_, TransactionManager tm_)
		{
			return GetByRetentionD7(retentionD7, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD7">7日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD7(float retentionD7, string sort_)
		{
			return GetByRetentionD7(retentionD7, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD7">7日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD7(float retentionD7, string sort_, TransactionManager tm_)
		{
			return GetByRetentionD7(retentionD7, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD7">7日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD7(float retentionD7, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RetentionD7` = @RetentionD7", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RetentionD7", retentionD7, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRetentionD7
		#region GetByRetentionD14
		
		/// <summary>
		/// 按 RetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD14">14日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD14(float retentionD14)
		{
			return GetByRetentionD14(retentionD14, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD14">14日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD14(float retentionD14, TransactionManager tm_)
		{
			return GetByRetentionD14(retentionD14, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD14">14日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD14(float retentionD14, int top_)
		{
			return GetByRetentionD14(retentionD14, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD14">14日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD14(float retentionD14, int top_, TransactionManager tm_)
		{
			return GetByRetentionD14(retentionD14, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD14">14日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD14(float retentionD14, string sort_)
		{
			return GetByRetentionD14(retentionD14, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD14">14日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD14(float retentionD14, string sort_, TransactionManager tm_)
		{
			return GetByRetentionD14(retentionD14, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD14">14日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD14(float retentionD14, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RetentionD14` = @RetentionD14", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RetentionD14", retentionD14, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRetentionD14
		#region GetByRetentionD15
		
		/// <summary>
		/// 按 RetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD15">15日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD15(float retentionD15)
		{
			return GetByRetentionD15(retentionD15, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD15">15日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD15(float retentionD15, TransactionManager tm_)
		{
			return GetByRetentionD15(retentionD15, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD15">15日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD15(float retentionD15, int top_)
		{
			return GetByRetentionD15(retentionD15, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD15">15日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD15(float retentionD15, int top_, TransactionManager tm_)
		{
			return GetByRetentionD15(retentionD15, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD15">15日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD15(float retentionD15, string sort_)
		{
			return GetByRetentionD15(retentionD15, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD15">15日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD15(float retentionD15, string sort_, TransactionManager tm_)
		{
			return GetByRetentionD15(retentionD15, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD15">15日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD15(float retentionD15, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RetentionD15` = @RetentionD15", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RetentionD15", retentionD15, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRetentionD15
		#region GetByRetentionD20
		
		/// <summary>
		/// 按 RetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD20">20日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD20(float retentionD20)
		{
			return GetByRetentionD20(retentionD20, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD20">20日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD20(float retentionD20, TransactionManager tm_)
		{
			return GetByRetentionD20(retentionD20, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD20">20日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD20(float retentionD20, int top_)
		{
			return GetByRetentionD20(retentionD20, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD20">20日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD20(float retentionD20, int top_, TransactionManager tm_)
		{
			return GetByRetentionD20(retentionD20, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD20">20日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD20(float retentionD20, string sort_)
		{
			return GetByRetentionD20(retentionD20, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD20">20日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD20(float retentionD20, string sort_, TransactionManager tm_)
		{
			return GetByRetentionD20(retentionD20, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD20">20日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD20(float retentionD20, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RetentionD20` = @RetentionD20", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RetentionD20", retentionD20, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRetentionD20
		#region GetByRetentionD30
		
		/// <summary>
		/// 按 RetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD30">30日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD30(float retentionD30)
		{
			return GetByRetentionD30(retentionD30, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD30">30日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD30(float retentionD30, TransactionManager tm_)
		{
			return GetByRetentionD30(retentionD30, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD30">30日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD30(float retentionD30, int top_)
		{
			return GetByRetentionD30(retentionD30, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD30">30日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD30(float retentionD30, int top_, TransactionManager tm_)
		{
			return GetByRetentionD30(retentionD30, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD30">30日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD30(float retentionD30, string sort_)
		{
			return GetByRetentionD30(retentionD30, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD30">30日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD30(float retentionD30, string sort_, TransactionManager tm_)
		{
			return GetByRetentionD30(retentionD30, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "retentionD30">30日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRetentionD30(float retentionD30, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RetentionD30` = @RetentionD30", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RetentionD30", retentionD30, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRetentionD30
		#region GetByRegRetentionD1
		
		/// <summary>
		/// 按 RegRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD1">注册1日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD1(float regRetentionD1)
		{
			return GetByRegRetentionD1(regRetentionD1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD1">注册1日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD1(float regRetentionD1, TransactionManager tm_)
		{
			return GetByRegRetentionD1(regRetentionD1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD1">注册1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD1(float regRetentionD1, int top_)
		{
			return GetByRegRetentionD1(regRetentionD1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD1">注册1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD1(float regRetentionD1, int top_, TransactionManager tm_)
		{
			return GetByRegRetentionD1(regRetentionD1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD1">注册1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD1(float regRetentionD1, string sort_)
		{
			return GetByRegRetentionD1(regRetentionD1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD1">注册1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD1(float regRetentionD1, string sort_, TransactionManager tm_)
		{
			return GetByRegRetentionD1(regRetentionD1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD1">注册1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD1(float regRetentionD1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegRetentionD1` = @RegRetentionD1", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RegRetentionD1", regRetentionD1, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRegRetentionD1
		#region GetByRegRetentionD3
		
		/// <summary>
		/// 按 RegRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD3">1日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD3(float regRetentionD3)
		{
			return GetByRegRetentionD3(regRetentionD3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD3">1日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD3(float regRetentionD3, TransactionManager tm_)
		{
			return GetByRegRetentionD3(regRetentionD3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD3">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD3(float regRetentionD3, int top_)
		{
			return GetByRegRetentionD3(regRetentionD3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD3">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD3(float regRetentionD3, int top_, TransactionManager tm_)
		{
			return GetByRegRetentionD3(regRetentionD3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD3">1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD3(float regRetentionD3, string sort_)
		{
			return GetByRegRetentionD3(regRetentionD3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD3">1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD3(float regRetentionD3, string sort_, TransactionManager tm_)
		{
			return GetByRegRetentionD3(regRetentionD3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD3">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD3(float regRetentionD3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegRetentionD3` = @RegRetentionD3", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RegRetentionD3", regRetentionD3, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRegRetentionD3
		#region GetByRegRetentionD7
		
		/// <summary>
		/// 按 RegRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD7">1日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD7(float regRetentionD7)
		{
			return GetByRegRetentionD7(regRetentionD7, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD7">1日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD7(float regRetentionD7, TransactionManager tm_)
		{
			return GetByRegRetentionD7(regRetentionD7, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD7">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD7(float regRetentionD7, int top_)
		{
			return GetByRegRetentionD7(regRetentionD7, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD7">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD7(float regRetentionD7, int top_, TransactionManager tm_)
		{
			return GetByRegRetentionD7(regRetentionD7, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD7">1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD7(float regRetentionD7, string sort_)
		{
			return GetByRegRetentionD7(regRetentionD7, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD7">1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD7(float regRetentionD7, string sort_, TransactionManager tm_)
		{
			return GetByRegRetentionD7(regRetentionD7, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD7">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD7(float regRetentionD7, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegRetentionD7` = @RegRetentionD7", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RegRetentionD7", regRetentionD7, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRegRetentionD7
		#region GetByRegRetentionD15
		
		/// <summary>
		/// 按 RegRetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD15">1日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD15(float regRetentionD15)
		{
			return GetByRegRetentionD15(regRetentionD15, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD15">1日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD15(float regRetentionD15, TransactionManager tm_)
		{
			return GetByRegRetentionD15(regRetentionD15, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD15">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD15(float regRetentionD15, int top_)
		{
			return GetByRegRetentionD15(regRetentionD15, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD15">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD15(float regRetentionD15, int top_, TransactionManager tm_)
		{
			return GetByRegRetentionD15(regRetentionD15, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD15">1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD15(float regRetentionD15, string sort_)
		{
			return GetByRegRetentionD15(regRetentionD15, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD15">1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD15(float regRetentionD15, string sort_, TransactionManager tm_)
		{
			return GetByRegRetentionD15(regRetentionD15, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD15（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD15">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD15(float regRetentionD15, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegRetentionD15` = @RegRetentionD15", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RegRetentionD15", regRetentionD15, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRegRetentionD15
		#region GetByRegRetentionD30
		
		/// <summary>
		/// 按 RegRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD30">1日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD30(float regRetentionD30)
		{
			return GetByRegRetentionD30(regRetentionD30, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD30">1日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD30(float regRetentionD30, TransactionManager tm_)
		{
			return GetByRegRetentionD30(regRetentionD30, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD30">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD30(float regRetentionD30, int top_)
		{
			return GetByRegRetentionD30(regRetentionD30, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD30">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD30(float regRetentionD30, int top_, TransactionManager tm_)
		{
			return GetByRegRetentionD30(regRetentionD30, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD30">1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD30(float regRetentionD30, string sort_)
		{
			return GetByRegRetentionD30(regRetentionD30, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD30">1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD30(float regRetentionD30, string sort_, TransactionManager tm_)
		{
			return GetByRegRetentionD30(regRetentionD30, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "regRetentionD30">1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRegRetentionD30(float regRetentionD30, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegRetentionD30` = @RegRetentionD30", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RegRetentionD30", regRetentionD30, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRegRetentionD30
		#region GetByPayRetentionD1
		
		/// <summary>
		/// 按 PayRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD1">充值1日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD1(float payRetentionD1)
		{
			return GetByPayRetentionD1(payRetentionD1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD1">充值1日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD1(float payRetentionD1, TransactionManager tm_)
		{
			return GetByPayRetentionD1(payRetentionD1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD1">充值1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD1(float payRetentionD1, int top_)
		{
			return GetByPayRetentionD1(payRetentionD1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD1">充值1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD1(float payRetentionD1, int top_, TransactionManager tm_)
		{
			return GetByPayRetentionD1(payRetentionD1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD1">充值1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD1(float payRetentionD1, string sort_)
		{
			return GetByPayRetentionD1(payRetentionD1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD1">充值1日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD1(float payRetentionD1, string sort_, TransactionManager tm_)
		{
			return GetByPayRetentionD1(payRetentionD1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD1（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD1">充值1日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD1(float payRetentionD1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayRetentionD1` = @PayRetentionD1", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayRetentionD1", payRetentionD1, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayRetentionD1
		#region GetByPayRetentionD2
		
		/// <summary>
		/// 按 PayRetentionD2（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD2">充值2日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD2(float payRetentionD2)
		{
			return GetByPayRetentionD2(payRetentionD2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD2（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD2">充值2日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD2(float payRetentionD2, TransactionManager tm_)
		{
			return GetByPayRetentionD2(payRetentionD2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD2（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD2">充值2日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD2(float payRetentionD2, int top_)
		{
			return GetByPayRetentionD2(payRetentionD2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD2（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD2">充值2日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD2(float payRetentionD2, int top_, TransactionManager tm_)
		{
			return GetByPayRetentionD2(payRetentionD2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD2（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD2">充值2日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD2(float payRetentionD2, string sort_)
		{
			return GetByPayRetentionD2(payRetentionD2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD2（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD2">充值2日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD2(float payRetentionD2, string sort_, TransactionManager tm_)
		{
			return GetByPayRetentionD2(payRetentionD2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD2（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD2">充值2日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD2(float payRetentionD2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayRetentionD2` = @PayRetentionD2", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayRetentionD2", payRetentionD2, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayRetentionD2
		#region GetByPayRetentionD3
		
		/// <summary>
		/// 按 PayRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD3">充值3日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD3(float payRetentionD3)
		{
			return GetByPayRetentionD3(payRetentionD3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD3">充值3日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD3(float payRetentionD3, TransactionManager tm_)
		{
			return GetByPayRetentionD3(payRetentionD3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD3">充值3日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD3(float payRetentionD3, int top_)
		{
			return GetByPayRetentionD3(payRetentionD3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD3">充值3日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD3(float payRetentionD3, int top_, TransactionManager tm_)
		{
			return GetByPayRetentionD3(payRetentionD3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD3">充值3日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD3(float payRetentionD3, string sort_)
		{
			return GetByPayRetentionD3(payRetentionD3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD3">充值3日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD3(float payRetentionD3, string sort_, TransactionManager tm_)
		{
			return GetByPayRetentionD3(payRetentionD3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD3（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD3">充值3日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD3(float payRetentionD3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayRetentionD3` = @PayRetentionD3", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayRetentionD3", payRetentionD3, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayRetentionD3
		#region GetByPayRetentionD4
		
		/// <summary>
		/// 按 PayRetentionD4（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD4">充值4日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD4(float payRetentionD4)
		{
			return GetByPayRetentionD4(payRetentionD4, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD4（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD4">充值4日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD4(float payRetentionD4, TransactionManager tm_)
		{
			return GetByPayRetentionD4(payRetentionD4, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD4（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD4">充值4日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD4(float payRetentionD4, int top_)
		{
			return GetByPayRetentionD4(payRetentionD4, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD4（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD4">充值4日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD4(float payRetentionD4, int top_, TransactionManager tm_)
		{
			return GetByPayRetentionD4(payRetentionD4, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD4（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD4">充值4日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD4(float payRetentionD4, string sort_)
		{
			return GetByPayRetentionD4(payRetentionD4, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD4（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD4">充值4日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD4(float payRetentionD4, string sort_, TransactionManager tm_)
		{
			return GetByPayRetentionD4(payRetentionD4, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD4（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD4">充值4日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD4(float payRetentionD4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayRetentionD4` = @PayRetentionD4", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayRetentionD4", payRetentionD4, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayRetentionD4
		#region GetByPayRetentionD5
		
		/// <summary>
		/// 按 PayRetentionD5（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD5">充值5日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD5(float payRetentionD5)
		{
			return GetByPayRetentionD5(payRetentionD5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD5（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD5">充值5日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD5(float payRetentionD5, TransactionManager tm_)
		{
			return GetByPayRetentionD5(payRetentionD5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD5（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD5">充值5日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD5(float payRetentionD5, int top_)
		{
			return GetByPayRetentionD5(payRetentionD5, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD5（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD5">充值5日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD5(float payRetentionD5, int top_, TransactionManager tm_)
		{
			return GetByPayRetentionD5(payRetentionD5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD5（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD5">充值5日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD5(float payRetentionD5, string sort_)
		{
			return GetByPayRetentionD5(payRetentionD5, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD5（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD5">充值5日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD5(float payRetentionD5, string sort_, TransactionManager tm_)
		{
			return GetByPayRetentionD5(payRetentionD5, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD5（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD5">充值5日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD5(float payRetentionD5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayRetentionD5` = @PayRetentionD5", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayRetentionD5", payRetentionD5, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayRetentionD5
		#region GetByPayRetentionD6
		
		/// <summary>
		/// 按 PayRetentionD6（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD6">充值6日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD6(float payRetentionD6)
		{
			return GetByPayRetentionD6(payRetentionD6, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD6（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD6">充值6日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD6(float payRetentionD6, TransactionManager tm_)
		{
			return GetByPayRetentionD6(payRetentionD6, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD6（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD6">充值6日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD6(float payRetentionD6, int top_)
		{
			return GetByPayRetentionD6(payRetentionD6, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD6（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD6">充值6日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD6(float payRetentionD6, int top_, TransactionManager tm_)
		{
			return GetByPayRetentionD6(payRetentionD6, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD6（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD6">充值6日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD6(float payRetentionD6, string sort_)
		{
			return GetByPayRetentionD6(payRetentionD6, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD6（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD6">充值6日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD6(float payRetentionD6, string sort_, TransactionManager tm_)
		{
			return GetByPayRetentionD6(payRetentionD6, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD6（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD6">充值6日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD6(float payRetentionD6, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayRetentionD6` = @PayRetentionD6", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayRetentionD6", payRetentionD6, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayRetentionD6
		#region GetByPayRetentionD7
		
		/// <summary>
		/// 按 PayRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD7">充值7日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD7(float payRetentionD7)
		{
			return GetByPayRetentionD7(payRetentionD7, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD7">充值7日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD7(float payRetentionD7, TransactionManager tm_)
		{
			return GetByPayRetentionD7(payRetentionD7, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD7">充值7日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD7(float payRetentionD7, int top_)
		{
			return GetByPayRetentionD7(payRetentionD7, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD7">充值7日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD7(float payRetentionD7, int top_, TransactionManager tm_)
		{
			return GetByPayRetentionD7(payRetentionD7, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD7">充值7日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD7(float payRetentionD7, string sort_)
		{
			return GetByPayRetentionD7(payRetentionD7, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD7">充值7日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD7(float payRetentionD7, string sort_, TransactionManager tm_)
		{
			return GetByPayRetentionD7(payRetentionD7, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD7（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD7">充值7日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD7(float payRetentionD7, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayRetentionD7` = @PayRetentionD7", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayRetentionD7", payRetentionD7, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayRetentionD7
		#region GetByPayRetentionD14
		
		/// <summary>
		/// 按 PayRetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD14">充值14日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD14(float payRetentionD14)
		{
			return GetByPayRetentionD14(payRetentionD14, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD14">充值14日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD14(float payRetentionD14, TransactionManager tm_)
		{
			return GetByPayRetentionD14(payRetentionD14, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD14">充值14日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD14(float payRetentionD14, int top_)
		{
			return GetByPayRetentionD14(payRetentionD14, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD14">充值14日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD14(float payRetentionD14, int top_, TransactionManager tm_)
		{
			return GetByPayRetentionD14(payRetentionD14, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD14">充值14日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD14(float payRetentionD14, string sort_)
		{
			return GetByPayRetentionD14(payRetentionD14, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD14">充值14日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD14(float payRetentionD14, string sort_, TransactionManager tm_)
		{
			return GetByPayRetentionD14(payRetentionD14, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD14（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD14">充值14日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD14(float payRetentionD14, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayRetentionD14` = @PayRetentionD14", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayRetentionD14", payRetentionD14, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayRetentionD14
		#region GetByPayRetentionD20
		
		/// <summary>
		/// 按 PayRetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD20">充值20日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD20(float payRetentionD20)
		{
			return GetByPayRetentionD20(payRetentionD20, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD20">充值20日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD20(float payRetentionD20, TransactionManager tm_)
		{
			return GetByPayRetentionD20(payRetentionD20, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD20">充值20日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD20(float payRetentionD20, int top_)
		{
			return GetByPayRetentionD20(payRetentionD20, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD20">充值20日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD20(float payRetentionD20, int top_, TransactionManager tm_)
		{
			return GetByPayRetentionD20(payRetentionD20, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD20">充值20日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD20(float payRetentionD20, string sort_)
		{
			return GetByPayRetentionD20(payRetentionD20, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD20">充值20日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD20(float payRetentionD20, string sort_, TransactionManager tm_)
		{
			return GetByPayRetentionD20(payRetentionD20, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD20（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD20">充值20日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD20(float payRetentionD20, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayRetentionD20` = @PayRetentionD20", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayRetentionD20", payRetentionD20, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayRetentionD20
		#region GetByPayRetentionD30
		
		/// <summary>
		/// 按 PayRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD30">充值30日留存率</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD30(float payRetentionD30)
		{
			return GetByPayRetentionD30(payRetentionD30, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD30">充值30日留存率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD30(float payRetentionD30, TransactionManager tm_)
		{
			return GetByPayRetentionD30(payRetentionD30, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD30">充值30日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD30(float payRetentionD30, int top_)
		{
			return GetByPayRetentionD30(payRetentionD30, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD30">充值30日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD30(float payRetentionD30, int top_, TransactionManager tm_)
		{
			return GetByPayRetentionD30(payRetentionD30, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD30">充值30日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD30(float payRetentionD30, string sort_)
		{
			return GetByPayRetentionD30(payRetentionD30, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD30">充值30日留存率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD30(float payRetentionD30, string sort_, TransactionManager tm_)
		{
			return GetByPayRetentionD30(payRetentionD30, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayRetentionD30（字段） 查询
		/// </summary>
		/// /// <param name = "payRetentionD30">充值30日留存率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPayRetentionD30(float payRetentionD30, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayRetentionD30` = @PayRetentionD30", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayRetentionD30", payRetentionD30, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPayRetentionD30
		#region GetByDNU_GGR1
		
		/// <summary>
		/// 按 DNU_GGR1（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR1">DNU_GGR1</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR1(long dNU_GGR1)
		{
			return GetByDNU_GGR1(dNU_GGR1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR1（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR1">DNU_GGR1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR1(long dNU_GGR1, TransactionManager tm_)
		{
			return GetByDNU_GGR1(dNU_GGR1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR1（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR1">DNU_GGR1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR1(long dNU_GGR1, int top_)
		{
			return GetByDNU_GGR1(dNU_GGR1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR1（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR1">DNU_GGR1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR1(long dNU_GGR1, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR1(dNU_GGR1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR1（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR1">DNU_GGR1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR1(long dNU_GGR1, string sort_)
		{
			return GetByDNU_GGR1(dNU_GGR1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR1（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR1">DNU_GGR1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR1(long dNU_GGR1, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR1(dNU_GGR1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR1（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR1">DNU_GGR1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR1(long dNU_GGR1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR1` = @DNU_GGR1", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR1", dNU_GGR1, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR1
		#region GetByDNU_GGR2
		
		/// <summary>
		/// 按 DNU_GGR2（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR2">DNU_GGR2</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR2(long dNU_GGR2)
		{
			return GetByDNU_GGR2(dNU_GGR2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR2（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR2">DNU_GGR2</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR2(long dNU_GGR2, TransactionManager tm_)
		{
			return GetByDNU_GGR2(dNU_GGR2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR2（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR2">DNU_GGR2</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR2(long dNU_GGR2, int top_)
		{
			return GetByDNU_GGR2(dNU_GGR2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR2（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR2">DNU_GGR2</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR2(long dNU_GGR2, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR2(dNU_GGR2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR2（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR2">DNU_GGR2</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR2(long dNU_GGR2, string sort_)
		{
			return GetByDNU_GGR2(dNU_GGR2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR2（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR2">DNU_GGR2</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR2(long dNU_GGR2, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR2(dNU_GGR2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR2（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR2">DNU_GGR2</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR2(long dNU_GGR2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR2` = @DNU_GGR2", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR2", dNU_GGR2, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR2
		#region GetByDNU_GGR3
		
		/// <summary>
		/// 按 DNU_GGR3（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR3">DNU_GGR3</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR3(long dNU_GGR3)
		{
			return GetByDNU_GGR3(dNU_GGR3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR3（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR3">DNU_GGR3</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR3(long dNU_GGR3, TransactionManager tm_)
		{
			return GetByDNU_GGR3(dNU_GGR3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR3（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR3">DNU_GGR3</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR3(long dNU_GGR3, int top_)
		{
			return GetByDNU_GGR3(dNU_GGR3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR3（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR3">DNU_GGR3</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR3(long dNU_GGR3, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR3(dNU_GGR3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR3（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR3">DNU_GGR3</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR3(long dNU_GGR3, string sort_)
		{
			return GetByDNU_GGR3(dNU_GGR3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR3（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR3">DNU_GGR3</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR3(long dNU_GGR3, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR3(dNU_GGR3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR3（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR3">DNU_GGR3</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR3(long dNU_GGR3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR3` = @DNU_GGR3", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR3", dNU_GGR3, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR3
		#region GetByDNU_GGR4
		
		/// <summary>
		/// 按 DNU_GGR4（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR4">DNU_GGR4</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR4(long dNU_GGR4)
		{
			return GetByDNU_GGR4(dNU_GGR4, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR4（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR4">DNU_GGR4</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR4(long dNU_GGR4, TransactionManager tm_)
		{
			return GetByDNU_GGR4(dNU_GGR4, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR4（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR4">DNU_GGR4</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR4(long dNU_GGR4, int top_)
		{
			return GetByDNU_GGR4(dNU_GGR4, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR4（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR4">DNU_GGR4</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR4(long dNU_GGR4, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR4(dNU_GGR4, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR4（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR4">DNU_GGR4</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR4(long dNU_GGR4, string sort_)
		{
			return GetByDNU_GGR4(dNU_GGR4, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR4（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR4">DNU_GGR4</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR4(long dNU_GGR4, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR4(dNU_GGR4, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR4（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR4">DNU_GGR4</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR4(long dNU_GGR4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR4` = @DNU_GGR4", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR4", dNU_GGR4, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR4
		#region GetByDNU_GGR5
		
		/// <summary>
		/// 按 DNU_GGR5（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR5">DNU_GGR5</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR5(long dNU_GGR5)
		{
			return GetByDNU_GGR5(dNU_GGR5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR5（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR5">DNU_GGR5</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR5(long dNU_GGR5, TransactionManager tm_)
		{
			return GetByDNU_GGR5(dNU_GGR5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR5（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR5">DNU_GGR5</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR5(long dNU_GGR5, int top_)
		{
			return GetByDNU_GGR5(dNU_GGR5, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR5（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR5">DNU_GGR5</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR5(long dNU_GGR5, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR5(dNU_GGR5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR5（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR5">DNU_GGR5</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR5(long dNU_GGR5, string sort_)
		{
			return GetByDNU_GGR5(dNU_GGR5, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR5（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR5">DNU_GGR5</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR5(long dNU_GGR5, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR5(dNU_GGR5, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR5（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR5">DNU_GGR5</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR5(long dNU_GGR5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR5` = @DNU_GGR5", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR5", dNU_GGR5, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR5
		#region GetByDNU_GGR6
		
		/// <summary>
		/// 按 DNU_GGR6（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR6">DNU_GGR6</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR6(long dNU_GGR6)
		{
			return GetByDNU_GGR6(dNU_GGR6, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR6（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR6">DNU_GGR6</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR6(long dNU_GGR6, TransactionManager tm_)
		{
			return GetByDNU_GGR6(dNU_GGR6, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR6（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR6">DNU_GGR6</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR6(long dNU_GGR6, int top_)
		{
			return GetByDNU_GGR6(dNU_GGR6, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR6（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR6">DNU_GGR6</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR6(long dNU_GGR6, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR6(dNU_GGR6, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR6（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR6">DNU_GGR6</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR6(long dNU_GGR6, string sort_)
		{
			return GetByDNU_GGR6(dNU_GGR6, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR6（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR6">DNU_GGR6</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR6(long dNU_GGR6, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR6(dNU_GGR6, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR6（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR6">DNU_GGR6</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR6(long dNU_GGR6, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR6` = @DNU_GGR6", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR6", dNU_GGR6, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR6
		#region GetByDNU_GGR7
		
		/// <summary>
		/// 按 DNU_GGR7（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR7">DNU_GGR7</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR7(long dNU_GGR7)
		{
			return GetByDNU_GGR7(dNU_GGR7, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR7（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR7">DNU_GGR7</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR7(long dNU_GGR7, TransactionManager tm_)
		{
			return GetByDNU_GGR7(dNU_GGR7, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR7（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR7">DNU_GGR7</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR7(long dNU_GGR7, int top_)
		{
			return GetByDNU_GGR7(dNU_GGR7, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR7（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR7">DNU_GGR7</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR7(long dNU_GGR7, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR7(dNU_GGR7, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR7（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR7">DNU_GGR7</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR7(long dNU_GGR7, string sort_)
		{
			return GetByDNU_GGR7(dNU_GGR7, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR7（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR7">DNU_GGR7</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR7(long dNU_GGR7, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR7(dNU_GGR7, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR7（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR7">DNU_GGR7</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR7(long dNU_GGR7, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR7` = @DNU_GGR7", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR7", dNU_GGR7, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR7
		#region GetByDNU_GGR8
		
		/// <summary>
		/// 按 DNU_GGR8（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR8">DNU_GGR8</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR8(long dNU_GGR8)
		{
			return GetByDNU_GGR8(dNU_GGR8, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR8（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR8">DNU_GGR8</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR8(long dNU_GGR8, TransactionManager tm_)
		{
			return GetByDNU_GGR8(dNU_GGR8, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR8（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR8">DNU_GGR8</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR8(long dNU_GGR8, int top_)
		{
			return GetByDNU_GGR8(dNU_GGR8, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR8（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR8">DNU_GGR8</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR8(long dNU_GGR8, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR8(dNU_GGR8, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR8（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR8">DNU_GGR8</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR8(long dNU_GGR8, string sort_)
		{
			return GetByDNU_GGR8(dNU_GGR8, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR8（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR8">DNU_GGR8</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR8(long dNU_GGR8, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR8(dNU_GGR8, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR8（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR8">DNU_GGR8</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR8(long dNU_GGR8, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR8` = @DNU_GGR8", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR8", dNU_GGR8, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR8
		#region GetByDNU_GGR9
		
		/// <summary>
		/// 按 DNU_GGR9（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR9">DNU_GGR9</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR9(long dNU_GGR9)
		{
			return GetByDNU_GGR9(dNU_GGR9, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR9（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR9">DNU_GGR9</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR9(long dNU_GGR9, TransactionManager tm_)
		{
			return GetByDNU_GGR9(dNU_GGR9, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR9（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR9">DNU_GGR9</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR9(long dNU_GGR9, int top_)
		{
			return GetByDNU_GGR9(dNU_GGR9, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR9（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR9">DNU_GGR9</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR9(long dNU_GGR9, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR9(dNU_GGR9, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR9（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR9">DNU_GGR9</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR9(long dNU_GGR9, string sort_)
		{
			return GetByDNU_GGR9(dNU_GGR9, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR9（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR9">DNU_GGR9</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR9(long dNU_GGR9, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR9(dNU_GGR9, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR9（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR9">DNU_GGR9</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR9(long dNU_GGR9, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR9` = @DNU_GGR9", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR9", dNU_GGR9, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR9
		#region GetByDNU_GGR10
		
		/// <summary>
		/// 按 DNU_GGR10（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR10">DNU_GGR10</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR10(long dNU_GGR10)
		{
			return GetByDNU_GGR10(dNU_GGR10, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR10（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR10">DNU_GGR10</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR10(long dNU_GGR10, TransactionManager tm_)
		{
			return GetByDNU_GGR10(dNU_GGR10, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR10（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR10">DNU_GGR10</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR10(long dNU_GGR10, int top_)
		{
			return GetByDNU_GGR10(dNU_GGR10, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR10（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR10">DNU_GGR10</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR10(long dNU_GGR10, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR10(dNU_GGR10, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR10（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR10">DNU_GGR10</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR10(long dNU_GGR10, string sort_)
		{
			return GetByDNU_GGR10(dNU_GGR10, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR10（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR10">DNU_GGR10</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR10(long dNU_GGR10, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR10(dNU_GGR10, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR10（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR10">DNU_GGR10</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR10(long dNU_GGR10, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR10` = @DNU_GGR10", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR10", dNU_GGR10, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR10
		#region GetByDNU_GGR11
		
		/// <summary>
		/// 按 DNU_GGR11（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR11">DNU_GGR11</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR11(long dNU_GGR11)
		{
			return GetByDNU_GGR11(dNU_GGR11, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR11（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR11">DNU_GGR11</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR11(long dNU_GGR11, TransactionManager tm_)
		{
			return GetByDNU_GGR11(dNU_GGR11, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR11（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR11">DNU_GGR11</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR11(long dNU_GGR11, int top_)
		{
			return GetByDNU_GGR11(dNU_GGR11, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR11（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR11">DNU_GGR11</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR11(long dNU_GGR11, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR11(dNU_GGR11, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR11（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR11">DNU_GGR11</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR11(long dNU_GGR11, string sort_)
		{
			return GetByDNU_GGR11(dNU_GGR11, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR11（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR11">DNU_GGR11</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR11(long dNU_GGR11, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR11(dNU_GGR11, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR11（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR11">DNU_GGR11</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR11(long dNU_GGR11, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR11` = @DNU_GGR11", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR11", dNU_GGR11, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR11
		#region GetByDNU_GGR12
		
		/// <summary>
		/// 按 DNU_GGR12（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR12">DNU_GGR12</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR12(long dNU_GGR12)
		{
			return GetByDNU_GGR12(dNU_GGR12, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR12（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR12">DNU_GGR12</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR12(long dNU_GGR12, TransactionManager tm_)
		{
			return GetByDNU_GGR12(dNU_GGR12, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR12（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR12">DNU_GGR12</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR12(long dNU_GGR12, int top_)
		{
			return GetByDNU_GGR12(dNU_GGR12, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR12（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR12">DNU_GGR12</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR12(long dNU_GGR12, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR12(dNU_GGR12, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR12（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR12">DNU_GGR12</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR12(long dNU_GGR12, string sort_)
		{
			return GetByDNU_GGR12(dNU_GGR12, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR12（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR12">DNU_GGR12</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR12(long dNU_GGR12, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR12(dNU_GGR12, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR12（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR12">DNU_GGR12</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR12(long dNU_GGR12, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR12` = @DNU_GGR12", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR12", dNU_GGR12, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR12
		#region GetByDNU_GGR13
		
		/// <summary>
		/// 按 DNU_GGR13（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR13">DNU_GGR13</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR13(long dNU_GGR13)
		{
			return GetByDNU_GGR13(dNU_GGR13, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR13（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR13">DNU_GGR13</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR13(long dNU_GGR13, TransactionManager tm_)
		{
			return GetByDNU_GGR13(dNU_GGR13, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR13（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR13">DNU_GGR13</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR13(long dNU_GGR13, int top_)
		{
			return GetByDNU_GGR13(dNU_GGR13, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR13（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR13">DNU_GGR13</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR13(long dNU_GGR13, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR13(dNU_GGR13, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR13（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR13">DNU_GGR13</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR13(long dNU_GGR13, string sort_)
		{
			return GetByDNU_GGR13(dNU_GGR13, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR13（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR13">DNU_GGR13</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR13(long dNU_GGR13, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR13(dNU_GGR13, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR13（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR13">DNU_GGR13</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR13(long dNU_GGR13, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR13` = @DNU_GGR13", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR13", dNU_GGR13, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR13
		#region GetByDNU_GGR14
		
		/// <summary>
		/// 按 DNU_GGR14（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR14">DNU_GGR14</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR14(long dNU_GGR14)
		{
			return GetByDNU_GGR14(dNU_GGR14, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR14（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR14">DNU_GGR14</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR14(long dNU_GGR14, TransactionManager tm_)
		{
			return GetByDNU_GGR14(dNU_GGR14, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR14（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR14">DNU_GGR14</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR14(long dNU_GGR14, int top_)
		{
			return GetByDNU_GGR14(dNU_GGR14, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR14（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR14">DNU_GGR14</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR14(long dNU_GGR14, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR14(dNU_GGR14, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR14（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR14">DNU_GGR14</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR14(long dNU_GGR14, string sort_)
		{
			return GetByDNU_GGR14(dNU_GGR14, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR14（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR14">DNU_GGR14</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR14(long dNU_GGR14, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR14(dNU_GGR14, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR14（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR14">DNU_GGR14</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR14(long dNU_GGR14, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR14` = @DNU_GGR14", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR14", dNU_GGR14, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR14
		#region GetByDNU_GGR15
		
		/// <summary>
		/// 按 DNU_GGR15（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR15">DNU_GGR15</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR15(long dNU_GGR15)
		{
			return GetByDNU_GGR15(dNU_GGR15, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR15（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR15">DNU_GGR15</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR15(long dNU_GGR15, TransactionManager tm_)
		{
			return GetByDNU_GGR15(dNU_GGR15, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR15（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR15">DNU_GGR15</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR15(long dNU_GGR15, int top_)
		{
			return GetByDNU_GGR15(dNU_GGR15, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR15（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR15">DNU_GGR15</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR15(long dNU_GGR15, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR15(dNU_GGR15, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR15（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR15">DNU_GGR15</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR15(long dNU_GGR15, string sort_)
		{
			return GetByDNU_GGR15(dNU_GGR15, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR15（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR15">DNU_GGR15</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR15(long dNU_GGR15, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR15(dNU_GGR15, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR15（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR15">DNU_GGR15</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR15(long dNU_GGR15, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR15` = @DNU_GGR15", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR15", dNU_GGR15, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR15
		#region GetByDNU_GGR16
		
		/// <summary>
		/// 按 DNU_GGR16（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR16">DNU_GGR16</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR16(long dNU_GGR16)
		{
			return GetByDNU_GGR16(dNU_GGR16, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR16（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR16">DNU_GGR16</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR16(long dNU_GGR16, TransactionManager tm_)
		{
			return GetByDNU_GGR16(dNU_GGR16, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR16（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR16">DNU_GGR16</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR16(long dNU_GGR16, int top_)
		{
			return GetByDNU_GGR16(dNU_GGR16, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR16（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR16">DNU_GGR16</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR16(long dNU_GGR16, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR16(dNU_GGR16, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR16（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR16">DNU_GGR16</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR16(long dNU_GGR16, string sort_)
		{
			return GetByDNU_GGR16(dNU_GGR16, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR16（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR16">DNU_GGR16</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR16(long dNU_GGR16, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR16(dNU_GGR16, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR16（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR16">DNU_GGR16</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR16(long dNU_GGR16, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR16` = @DNU_GGR16", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR16", dNU_GGR16, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR16
		#region GetByDNU_GGR17
		
		/// <summary>
		/// 按 DNU_GGR17（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR17">DNU_GGR17</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR17(long dNU_GGR17)
		{
			return GetByDNU_GGR17(dNU_GGR17, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR17（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR17">DNU_GGR17</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR17(long dNU_GGR17, TransactionManager tm_)
		{
			return GetByDNU_GGR17(dNU_GGR17, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR17（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR17">DNU_GGR17</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR17(long dNU_GGR17, int top_)
		{
			return GetByDNU_GGR17(dNU_GGR17, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR17（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR17">DNU_GGR17</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR17(long dNU_GGR17, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR17(dNU_GGR17, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR17（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR17">DNU_GGR17</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR17(long dNU_GGR17, string sort_)
		{
			return GetByDNU_GGR17(dNU_GGR17, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR17（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR17">DNU_GGR17</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR17(long dNU_GGR17, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR17(dNU_GGR17, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR17（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR17">DNU_GGR17</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR17(long dNU_GGR17, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR17` = @DNU_GGR17", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR17", dNU_GGR17, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR17
		#region GetByDNU_GGR18
		
		/// <summary>
		/// 按 DNU_GGR18（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR18">DNU_GGR18</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR18(long dNU_GGR18)
		{
			return GetByDNU_GGR18(dNU_GGR18, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR18（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR18">DNU_GGR18</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR18(long dNU_GGR18, TransactionManager tm_)
		{
			return GetByDNU_GGR18(dNU_GGR18, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR18（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR18">DNU_GGR18</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR18(long dNU_GGR18, int top_)
		{
			return GetByDNU_GGR18(dNU_GGR18, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR18（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR18">DNU_GGR18</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR18(long dNU_GGR18, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR18(dNU_GGR18, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR18（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR18">DNU_GGR18</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR18(long dNU_GGR18, string sort_)
		{
			return GetByDNU_GGR18(dNU_GGR18, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR18（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR18">DNU_GGR18</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR18(long dNU_GGR18, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR18(dNU_GGR18, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR18（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR18">DNU_GGR18</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR18(long dNU_GGR18, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR18` = @DNU_GGR18", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR18", dNU_GGR18, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR18
		#region GetByDNU_GGR19
		
		/// <summary>
		/// 按 DNU_GGR19（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR19">DNU_GGR19</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR19(long dNU_GGR19)
		{
			return GetByDNU_GGR19(dNU_GGR19, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR19（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR19">DNU_GGR19</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR19(long dNU_GGR19, TransactionManager tm_)
		{
			return GetByDNU_GGR19(dNU_GGR19, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR19（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR19">DNU_GGR19</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR19(long dNU_GGR19, int top_)
		{
			return GetByDNU_GGR19(dNU_GGR19, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR19（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR19">DNU_GGR19</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR19(long dNU_GGR19, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR19(dNU_GGR19, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR19（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR19">DNU_GGR19</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR19(long dNU_GGR19, string sort_)
		{
			return GetByDNU_GGR19(dNU_GGR19, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR19（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR19">DNU_GGR19</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR19(long dNU_GGR19, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR19(dNU_GGR19, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR19（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR19">DNU_GGR19</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR19(long dNU_GGR19, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR19` = @DNU_GGR19", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR19", dNU_GGR19, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR19
		#region GetByDNU_GGR20
		
		/// <summary>
		/// 按 DNU_GGR20（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR20">DNU_GGR20</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR20(long dNU_GGR20)
		{
			return GetByDNU_GGR20(dNU_GGR20, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR20（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR20">DNU_GGR20</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR20(long dNU_GGR20, TransactionManager tm_)
		{
			return GetByDNU_GGR20(dNU_GGR20, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR20（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR20">DNU_GGR20</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR20(long dNU_GGR20, int top_)
		{
			return GetByDNU_GGR20(dNU_GGR20, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR20（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR20">DNU_GGR20</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR20(long dNU_GGR20, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR20(dNU_GGR20, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR20（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR20">DNU_GGR20</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR20(long dNU_GGR20, string sort_)
		{
			return GetByDNU_GGR20(dNU_GGR20, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR20（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR20">DNU_GGR20</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR20(long dNU_GGR20, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR20(dNU_GGR20, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR20（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR20">DNU_GGR20</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR20(long dNU_GGR20, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR20` = @DNU_GGR20", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR20", dNU_GGR20, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR20
		#region GetByDNU_GGR21
		
		/// <summary>
		/// 按 DNU_GGR21（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR21">DNU_GGR21</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR21(long dNU_GGR21)
		{
			return GetByDNU_GGR21(dNU_GGR21, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR21（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR21">DNU_GGR21</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR21(long dNU_GGR21, TransactionManager tm_)
		{
			return GetByDNU_GGR21(dNU_GGR21, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR21（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR21">DNU_GGR21</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR21(long dNU_GGR21, int top_)
		{
			return GetByDNU_GGR21(dNU_GGR21, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR21（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR21">DNU_GGR21</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR21(long dNU_GGR21, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR21(dNU_GGR21, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR21（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR21">DNU_GGR21</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR21(long dNU_GGR21, string sort_)
		{
			return GetByDNU_GGR21(dNU_GGR21, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR21（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR21">DNU_GGR21</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR21(long dNU_GGR21, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR21(dNU_GGR21, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR21（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR21">DNU_GGR21</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR21(long dNU_GGR21, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR21` = @DNU_GGR21", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR21", dNU_GGR21, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR21
		#region GetByDNU_GGR22
		
		/// <summary>
		/// 按 DNU_GGR22（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR22">DNU_GGR22</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR22(long dNU_GGR22)
		{
			return GetByDNU_GGR22(dNU_GGR22, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR22（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR22">DNU_GGR22</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR22(long dNU_GGR22, TransactionManager tm_)
		{
			return GetByDNU_GGR22(dNU_GGR22, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR22（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR22">DNU_GGR22</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR22(long dNU_GGR22, int top_)
		{
			return GetByDNU_GGR22(dNU_GGR22, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR22（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR22">DNU_GGR22</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR22(long dNU_GGR22, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR22(dNU_GGR22, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR22（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR22">DNU_GGR22</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR22(long dNU_GGR22, string sort_)
		{
			return GetByDNU_GGR22(dNU_GGR22, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR22（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR22">DNU_GGR22</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR22(long dNU_GGR22, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR22(dNU_GGR22, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR22（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR22">DNU_GGR22</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR22(long dNU_GGR22, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR22` = @DNU_GGR22", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR22", dNU_GGR22, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR22
		#region GetByDNU_GGR23
		
		/// <summary>
		/// 按 DNU_GGR23（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR23">DNU_GGR23</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR23(long dNU_GGR23)
		{
			return GetByDNU_GGR23(dNU_GGR23, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR23（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR23">DNU_GGR23</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR23(long dNU_GGR23, TransactionManager tm_)
		{
			return GetByDNU_GGR23(dNU_GGR23, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR23（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR23">DNU_GGR23</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR23(long dNU_GGR23, int top_)
		{
			return GetByDNU_GGR23(dNU_GGR23, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR23（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR23">DNU_GGR23</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR23(long dNU_GGR23, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR23(dNU_GGR23, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR23（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR23">DNU_GGR23</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR23(long dNU_GGR23, string sort_)
		{
			return GetByDNU_GGR23(dNU_GGR23, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR23（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR23">DNU_GGR23</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR23(long dNU_GGR23, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR23(dNU_GGR23, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR23（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR23">DNU_GGR23</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR23(long dNU_GGR23, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR23` = @DNU_GGR23", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR23", dNU_GGR23, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR23
		#region GetByDNU_GGR24
		
		/// <summary>
		/// 按 DNU_GGR24（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR24">DNU_GGR24</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR24(long dNU_GGR24)
		{
			return GetByDNU_GGR24(dNU_GGR24, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR24（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR24">DNU_GGR24</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR24(long dNU_GGR24, TransactionManager tm_)
		{
			return GetByDNU_GGR24(dNU_GGR24, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR24（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR24">DNU_GGR24</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR24(long dNU_GGR24, int top_)
		{
			return GetByDNU_GGR24(dNU_GGR24, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR24（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR24">DNU_GGR24</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR24(long dNU_GGR24, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR24(dNU_GGR24, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR24（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR24">DNU_GGR24</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR24(long dNU_GGR24, string sort_)
		{
			return GetByDNU_GGR24(dNU_GGR24, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR24（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR24">DNU_GGR24</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR24(long dNU_GGR24, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR24(dNU_GGR24, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR24（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR24">DNU_GGR24</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR24(long dNU_GGR24, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR24` = @DNU_GGR24", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR24", dNU_GGR24, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR24
		#region GetByDNU_GGR25
		
		/// <summary>
		/// 按 DNU_GGR25（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR25">DNU_GGR25</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR25(long dNU_GGR25)
		{
			return GetByDNU_GGR25(dNU_GGR25, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR25（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR25">DNU_GGR25</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR25(long dNU_GGR25, TransactionManager tm_)
		{
			return GetByDNU_GGR25(dNU_GGR25, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR25（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR25">DNU_GGR25</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR25(long dNU_GGR25, int top_)
		{
			return GetByDNU_GGR25(dNU_GGR25, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR25（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR25">DNU_GGR25</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR25(long dNU_GGR25, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR25(dNU_GGR25, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR25（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR25">DNU_GGR25</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR25(long dNU_GGR25, string sort_)
		{
			return GetByDNU_GGR25(dNU_GGR25, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR25（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR25">DNU_GGR25</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR25(long dNU_GGR25, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR25(dNU_GGR25, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR25（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR25">DNU_GGR25</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR25(long dNU_GGR25, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR25` = @DNU_GGR25", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR25", dNU_GGR25, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR25
		#region GetByDNU_GGR26
		
		/// <summary>
		/// 按 DNU_GGR26（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR26">DNU_GGR26</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR26(long dNU_GGR26)
		{
			return GetByDNU_GGR26(dNU_GGR26, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR26（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR26">DNU_GGR26</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR26(long dNU_GGR26, TransactionManager tm_)
		{
			return GetByDNU_GGR26(dNU_GGR26, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR26（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR26">DNU_GGR26</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR26(long dNU_GGR26, int top_)
		{
			return GetByDNU_GGR26(dNU_GGR26, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR26（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR26">DNU_GGR26</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR26(long dNU_GGR26, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR26(dNU_GGR26, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR26（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR26">DNU_GGR26</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR26(long dNU_GGR26, string sort_)
		{
			return GetByDNU_GGR26(dNU_GGR26, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR26（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR26">DNU_GGR26</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR26(long dNU_GGR26, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR26(dNU_GGR26, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR26（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR26">DNU_GGR26</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR26(long dNU_GGR26, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR26` = @DNU_GGR26", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR26", dNU_GGR26, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR26
		#region GetByDNU_GGR27
		
		/// <summary>
		/// 按 DNU_GGR27（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR27">DNU_GGR27</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR27(long dNU_GGR27)
		{
			return GetByDNU_GGR27(dNU_GGR27, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR27（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR27">DNU_GGR27</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR27(long dNU_GGR27, TransactionManager tm_)
		{
			return GetByDNU_GGR27(dNU_GGR27, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR27（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR27">DNU_GGR27</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR27(long dNU_GGR27, int top_)
		{
			return GetByDNU_GGR27(dNU_GGR27, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR27（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR27">DNU_GGR27</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR27(long dNU_GGR27, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR27(dNU_GGR27, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR27（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR27">DNU_GGR27</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR27(long dNU_GGR27, string sort_)
		{
			return GetByDNU_GGR27(dNU_GGR27, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR27（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR27">DNU_GGR27</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR27(long dNU_GGR27, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR27(dNU_GGR27, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR27（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR27">DNU_GGR27</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR27(long dNU_GGR27, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR27` = @DNU_GGR27", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR27", dNU_GGR27, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR27
		#region GetByDNU_GGR28
		
		/// <summary>
		/// 按 DNU_GGR28（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR28">DNU_GGR28</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR28(long dNU_GGR28)
		{
			return GetByDNU_GGR28(dNU_GGR28, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR28（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR28">DNU_GGR28</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR28(long dNU_GGR28, TransactionManager tm_)
		{
			return GetByDNU_GGR28(dNU_GGR28, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR28（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR28">DNU_GGR28</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR28(long dNU_GGR28, int top_)
		{
			return GetByDNU_GGR28(dNU_GGR28, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR28（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR28">DNU_GGR28</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR28(long dNU_GGR28, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR28(dNU_GGR28, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR28（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR28">DNU_GGR28</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR28(long dNU_GGR28, string sort_)
		{
			return GetByDNU_GGR28(dNU_GGR28, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR28（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR28">DNU_GGR28</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR28(long dNU_GGR28, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR28(dNU_GGR28, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR28（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR28">DNU_GGR28</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR28(long dNU_GGR28, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR28` = @DNU_GGR28", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR28", dNU_GGR28, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR28
		#region GetByDNU_GGR29
		
		/// <summary>
		/// 按 DNU_GGR29（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR29">DNU_GGR29</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR29(long dNU_GGR29)
		{
			return GetByDNU_GGR29(dNU_GGR29, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR29（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR29">DNU_GGR29</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR29(long dNU_GGR29, TransactionManager tm_)
		{
			return GetByDNU_GGR29(dNU_GGR29, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR29（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR29">DNU_GGR29</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR29(long dNU_GGR29, int top_)
		{
			return GetByDNU_GGR29(dNU_GGR29, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR29（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR29">DNU_GGR29</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR29(long dNU_GGR29, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR29(dNU_GGR29, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR29（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR29">DNU_GGR29</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR29(long dNU_GGR29, string sort_)
		{
			return GetByDNU_GGR29(dNU_GGR29, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR29（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR29">DNU_GGR29</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR29(long dNU_GGR29, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR29(dNU_GGR29, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR29（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR29">DNU_GGR29</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR29(long dNU_GGR29, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR29` = @DNU_GGR29", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR29", dNU_GGR29, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR29
		#region GetByDNU_GGR30
		
		/// <summary>
		/// 按 DNU_GGR30（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR30">DNU_GGR30</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR30(long dNU_GGR30)
		{
			return GetByDNU_GGR30(dNU_GGR30, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR30（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR30">DNU_GGR30</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR30(long dNU_GGR30, TransactionManager tm_)
		{
			return GetByDNU_GGR30(dNU_GGR30, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR30（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR30">DNU_GGR30</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR30(long dNU_GGR30, int top_)
		{
			return GetByDNU_GGR30(dNU_GGR30, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR30（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR30">DNU_GGR30</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR30(long dNU_GGR30, int top_, TransactionManager tm_)
		{
			return GetByDNU_GGR30(dNU_GGR30, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR30（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR30">DNU_GGR30</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR30(long dNU_GGR30, string sort_)
		{
			return GetByDNU_GGR30(dNU_GGR30, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DNU_GGR30（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR30">DNU_GGR30</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR30(long dNU_GGR30, string sort_, TransactionManager tm_)
		{
			return GetByDNU_GGR30(dNU_GGR30, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DNU_GGR30（字段） 查询
		/// </summary>
		/// /// <param name = "dNU_GGR30">DNU_GGR30</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByDNU_GGR30(long dNU_GGR30, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DNU_GGR30` = @DNU_GGR30", top_, sort_);
			var parameter_ = Database.CreateInParameter("@DNU_GGR30", dNU_GGR30, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByDNU_GGR30
		#region GetByLose10
		
		/// <summary>
		/// 按 Lose10（字段） 查询
		/// </summary>
		/// /// <param name = "lose10">输10</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10(int lose10)
		{
			return GetByLose10(lose10, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose10（字段） 查询
		/// </summary>
		/// /// <param name = "lose10">输10</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10(int lose10, TransactionManager tm_)
		{
			return GetByLose10(lose10, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose10（字段） 查询
		/// </summary>
		/// /// <param name = "lose10">输10</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10(int lose10, int top_)
		{
			return GetByLose10(lose10, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose10（字段） 查询
		/// </summary>
		/// /// <param name = "lose10">输10</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10(int lose10, int top_, TransactionManager tm_)
		{
			return GetByLose10(lose10, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose10（字段） 查询
		/// </summary>
		/// /// <param name = "lose10">输10</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10(int lose10, string sort_)
		{
			return GetByLose10(lose10, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Lose10（字段） 查询
		/// </summary>
		/// /// <param name = "lose10">输10</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10(int lose10, string sort_, TransactionManager tm_)
		{
			return GetByLose10(lose10, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Lose10（字段） 查询
		/// </summary>
		/// /// <param name = "lose10">输10</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10(int lose10, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Lose10` = @Lose10", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Lose10", lose10, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByLose10
		#region GetByLose10_100
		
		/// <summary>
		/// 按 Lose10_100（字段） 查询
		/// </summary>
		/// /// <param name = "lose10_100">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10_100(int lose10_100)
		{
			return GetByLose10_100(lose10_100, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose10_100（字段） 查询
		/// </summary>
		/// /// <param name = "lose10_100">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10_100(int lose10_100, TransactionManager tm_)
		{
			return GetByLose10_100(lose10_100, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose10_100（字段） 查询
		/// </summary>
		/// /// <param name = "lose10_100">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10_100(int lose10_100, int top_)
		{
			return GetByLose10_100(lose10_100, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose10_100（字段） 查询
		/// </summary>
		/// /// <param name = "lose10_100">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10_100(int lose10_100, int top_, TransactionManager tm_)
		{
			return GetByLose10_100(lose10_100, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose10_100（字段） 查询
		/// </summary>
		/// /// <param name = "lose10_100">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10_100(int lose10_100, string sort_)
		{
			return GetByLose10_100(lose10_100, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Lose10_100（字段） 查询
		/// </summary>
		/// /// <param name = "lose10_100">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10_100(int lose10_100, string sort_, TransactionManager tm_)
		{
			return GetByLose10_100(lose10_100, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Lose10_100（字段） 查询
		/// </summary>
		/// /// <param name = "lose10_100">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10_100(int lose10_100, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Lose10_100` = @Lose10_100", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Lose10_100", lose10_100, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByLose10_100
		#region GetByLose100_500
		
		/// <summary>
		/// 按 Lose100_500（字段） 查询
		/// </summary>
		/// /// <param name = "lose100_500">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose100_500(int lose100_500)
		{
			return GetByLose100_500(lose100_500, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose100_500（字段） 查询
		/// </summary>
		/// /// <param name = "lose100_500">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose100_500(int lose100_500, TransactionManager tm_)
		{
			return GetByLose100_500(lose100_500, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose100_500（字段） 查询
		/// </summary>
		/// /// <param name = "lose100_500">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose100_500(int lose100_500, int top_)
		{
			return GetByLose100_500(lose100_500, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose100_500（字段） 查询
		/// </summary>
		/// /// <param name = "lose100_500">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose100_500(int lose100_500, int top_, TransactionManager tm_)
		{
			return GetByLose100_500(lose100_500, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose100_500（字段） 查询
		/// </summary>
		/// /// <param name = "lose100_500">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose100_500(int lose100_500, string sort_)
		{
			return GetByLose100_500(lose100_500, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Lose100_500（字段） 查询
		/// </summary>
		/// /// <param name = "lose100_500">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose100_500(int lose100_500, string sort_, TransactionManager tm_)
		{
			return GetByLose100_500(lose100_500, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Lose100_500（字段） 查询
		/// </summary>
		/// /// <param name = "lose100_500">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose100_500(int lose100_500, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Lose100_500` = @Lose100_500", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Lose100_500", lose100_500, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByLose100_500
		#region GetByLose500_1000
		
		/// <summary>
		/// 按 Lose500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "lose500_1000">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose500_1000(int lose500_1000)
		{
			return GetByLose500_1000(lose500_1000, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "lose500_1000">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose500_1000(int lose500_1000, TransactionManager tm_)
		{
			return GetByLose500_1000(lose500_1000, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "lose500_1000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose500_1000(int lose500_1000, int top_)
		{
			return GetByLose500_1000(lose500_1000, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "lose500_1000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose500_1000(int lose500_1000, int top_, TransactionManager tm_)
		{
			return GetByLose500_1000(lose500_1000, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "lose500_1000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose500_1000(int lose500_1000, string sort_)
		{
			return GetByLose500_1000(lose500_1000, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Lose500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "lose500_1000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose500_1000(int lose500_1000, string sort_, TransactionManager tm_)
		{
			return GetByLose500_1000(lose500_1000, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Lose500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "lose500_1000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose500_1000(int lose500_1000, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Lose500_1000` = @Lose500_1000", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Lose500_1000", lose500_1000, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByLose500_1000
		#region GetByLose1000_3000
		
		/// <summary>
		/// 按 Lose1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "lose1000_3000">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose1000_3000(int lose1000_3000)
		{
			return GetByLose1000_3000(lose1000_3000, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "lose1000_3000">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose1000_3000(int lose1000_3000, TransactionManager tm_)
		{
			return GetByLose1000_3000(lose1000_3000, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "lose1000_3000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose1000_3000(int lose1000_3000, int top_)
		{
			return GetByLose1000_3000(lose1000_3000, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "lose1000_3000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose1000_3000(int lose1000_3000, int top_, TransactionManager tm_)
		{
			return GetByLose1000_3000(lose1000_3000, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "lose1000_3000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose1000_3000(int lose1000_3000, string sort_)
		{
			return GetByLose1000_3000(lose1000_3000, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Lose1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "lose1000_3000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose1000_3000(int lose1000_3000, string sort_, TransactionManager tm_)
		{
			return GetByLose1000_3000(lose1000_3000, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Lose1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "lose1000_3000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose1000_3000(int lose1000_3000, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Lose1000_3000` = @Lose1000_3000", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Lose1000_3000", lose1000_3000, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByLose1000_3000
		#region GetByLose3000_5000
		
		/// <summary>
		/// 按 Lose3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "lose3000_5000">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose3000_5000(int lose3000_5000)
		{
			return GetByLose3000_5000(lose3000_5000, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "lose3000_5000">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose3000_5000(int lose3000_5000, TransactionManager tm_)
		{
			return GetByLose3000_5000(lose3000_5000, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "lose3000_5000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose3000_5000(int lose3000_5000, int top_)
		{
			return GetByLose3000_5000(lose3000_5000, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "lose3000_5000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose3000_5000(int lose3000_5000, int top_, TransactionManager tm_)
		{
			return GetByLose3000_5000(lose3000_5000, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "lose3000_5000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose3000_5000(int lose3000_5000, string sort_)
		{
			return GetByLose3000_5000(lose3000_5000, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Lose3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "lose3000_5000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose3000_5000(int lose3000_5000, string sort_, TransactionManager tm_)
		{
			return GetByLose3000_5000(lose3000_5000, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Lose3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "lose3000_5000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose3000_5000(int lose3000_5000, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Lose3000_5000` = @Lose3000_5000", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Lose3000_5000", lose3000_5000, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByLose3000_5000
		#region GetByLose5000_10000
		
		/// <summary>
		/// 按 Lose5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "lose5000_10000">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose5000_10000(int lose5000_10000)
		{
			return GetByLose5000_10000(lose5000_10000, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "lose5000_10000">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose5000_10000(int lose5000_10000, TransactionManager tm_)
		{
			return GetByLose5000_10000(lose5000_10000, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "lose5000_10000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose5000_10000(int lose5000_10000, int top_)
		{
			return GetByLose5000_10000(lose5000_10000, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "lose5000_10000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose5000_10000(int lose5000_10000, int top_, TransactionManager tm_)
		{
			return GetByLose5000_10000(lose5000_10000, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "lose5000_10000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose5000_10000(int lose5000_10000, string sort_)
		{
			return GetByLose5000_10000(lose5000_10000, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Lose5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "lose5000_10000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose5000_10000(int lose5000_10000, string sort_, TransactionManager tm_)
		{
			return GetByLose5000_10000(lose5000_10000, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Lose5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "lose5000_10000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose5000_10000(int lose5000_10000, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Lose5000_10000` = @Lose5000_10000", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Lose5000_10000", lose5000_10000, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByLose5000_10000
		#region GetByLose10000_50000
		
		/// <summary>
		/// 按 Lose10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose10000_50000">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10000_50000(int lose10000_50000)
		{
			return GetByLose10000_50000(lose10000_50000, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose10000_50000">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10000_50000(int lose10000_50000, TransactionManager tm_)
		{
			return GetByLose10000_50000(lose10000_50000, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose10000_50000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10000_50000(int lose10000_50000, int top_)
		{
			return GetByLose10000_50000(lose10000_50000, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose10000_50000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10000_50000(int lose10000_50000, int top_, TransactionManager tm_)
		{
			return GetByLose10000_50000(lose10000_50000, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose10000_50000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10000_50000(int lose10000_50000, string sort_)
		{
			return GetByLose10000_50000(lose10000_50000, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Lose10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose10000_50000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10000_50000(int lose10000_50000, string sort_, TransactionManager tm_)
		{
			return GetByLose10000_50000(lose10000_50000, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Lose10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose10000_50000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose10000_50000(int lose10000_50000, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Lose10000_50000` = @Lose10000_50000", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Lose10000_50000", lose10000_50000, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByLose10000_50000
		#region GetByLose50000
		
		/// <summary>
		/// 按 Lose50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose50000">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose50000(int lose50000)
		{
			return GetByLose50000(lose50000, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose50000">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose50000(int lose50000, TransactionManager tm_)
		{
			return GetByLose50000(lose50000, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose50000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose50000(int lose50000, int top_)
		{
			return GetByLose50000(lose50000, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Lose50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose50000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose50000(int lose50000, int top_, TransactionManager tm_)
		{
			return GetByLose50000(lose50000, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Lose50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose50000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose50000(int lose50000, string sort_)
		{
			return GetByLose50000(lose50000, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Lose50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose50000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose50000(int lose50000, string sort_, TransactionManager tm_)
		{
			return GetByLose50000(lose50000, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Lose50000（字段） 查询
		/// </summary>
		/// /// <param name = "lose50000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByLose50000(int lose50000, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Lose50000` = @Lose50000", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Lose50000", lose50000, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByLose50000
		#region GetByWin10
		
		/// <summary>
		/// 按 Win10（字段） 查询
		/// </summary>
		/// /// <param name = "win10">输10</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10(int win10)
		{
			return GetByWin10(win10, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win10（字段） 查询
		/// </summary>
		/// /// <param name = "win10">输10</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10(int win10, TransactionManager tm_)
		{
			return GetByWin10(win10, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win10（字段） 查询
		/// </summary>
		/// /// <param name = "win10">输10</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10(int win10, int top_)
		{
			return GetByWin10(win10, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win10（字段） 查询
		/// </summary>
		/// /// <param name = "win10">输10</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10(int win10, int top_, TransactionManager tm_)
		{
			return GetByWin10(win10, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win10（字段） 查询
		/// </summary>
		/// /// <param name = "win10">输10</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10(int win10, string sort_)
		{
			return GetByWin10(win10, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Win10（字段） 查询
		/// </summary>
		/// /// <param name = "win10">输10</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10(int win10, string sort_, TransactionManager tm_)
		{
			return GetByWin10(win10, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Win10（字段） 查询
		/// </summary>
		/// /// <param name = "win10">输10</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10(int win10, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Win10` = @Win10", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Win10", win10, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByWin10
		#region GetByWin10_100
		
		/// <summary>
		/// 按 Win10_100（字段） 查询
		/// </summary>
		/// /// <param name = "win10_100">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10_100(int win10_100)
		{
			return GetByWin10_100(win10_100, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win10_100（字段） 查询
		/// </summary>
		/// /// <param name = "win10_100">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10_100(int win10_100, TransactionManager tm_)
		{
			return GetByWin10_100(win10_100, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win10_100（字段） 查询
		/// </summary>
		/// /// <param name = "win10_100">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10_100(int win10_100, int top_)
		{
			return GetByWin10_100(win10_100, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win10_100（字段） 查询
		/// </summary>
		/// /// <param name = "win10_100">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10_100(int win10_100, int top_, TransactionManager tm_)
		{
			return GetByWin10_100(win10_100, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win10_100（字段） 查询
		/// </summary>
		/// /// <param name = "win10_100">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10_100(int win10_100, string sort_)
		{
			return GetByWin10_100(win10_100, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Win10_100（字段） 查询
		/// </summary>
		/// /// <param name = "win10_100">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10_100(int win10_100, string sort_, TransactionManager tm_)
		{
			return GetByWin10_100(win10_100, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Win10_100（字段） 查询
		/// </summary>
		/// /// <param name = "win10_100">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10_100(int win10_100, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Win10_100` = @Win10_100", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Win10_100", win10_100, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByWin10_100
		#region GetByWin100_500
		
		/// <summary>
		/// 按 Win100_500（字段） 查询
		/// </summary>
		/// /// <param name = "win100_500">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin100_500(int win100_500)
		{
			return GetByWin100_500(win100_500, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win100_500（字段） 查询
		/// </summary>
		/// /// <param name = "win100_500">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin100_500(int win100_500, TransactionManager tm_)
		{
			return GetByWin100_500(win100_500, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win100_500（字段） 查询
		/// </summary>
		/// /// <param name = "win100_500">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin100_500(int win100_500, int top_)
		{
			return GetByWin100_500(win100_500, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win100_500（字段） 查询
		/// </summary>
		/// /// <param name = "win100_500">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin100_500(int win100_500, int top_, TransactionManager tm_)
		{
			return GetByWin100_500(win100_500, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win100_500（字段） 查询
		/// </summary>
		/// /// <param name = "win100_500">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin100_500(int win100_500, string sort_)
		{
			return GetByWin100_500(win100_500, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Win100_500（字段） 查询
		/// </summary>
		/// /// <param name = "win100_500">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin100_500(int win100_500, string sort_, TransactionManager tm_)
		{
			return GetByWin100_500(win100_500, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Win100_500（字段） 查询
		/// </summary>
		/// /// <param name = "win100_500">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin100_500(int win100_500, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Win100_500` = @Win100_500", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Win100_500", win100_500, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByWin100_500
		#region GetByWin500_1000
		
		/// <summary>
		/// 按 Win500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "win500_1000">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin500_1000(int win500_1000)
		{
			return GetByWin500_1000(win500_1000, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "win500_1000">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin500_1000(int win500_1000, TransactionManager tm_)
		{
			return GetByWin500_1000(win500_1000, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "win500_1000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin500_1000(int win500_1000, int top_)
		{
			return GetByWin500_1000(win500_1000, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "win500_1000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin500_1000(int win500_1000, int top_, TransactionManager tm_)
		{
			return GetByWin500_1000(win500_1000, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "win500_1000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin500_1000(int win500_1000, string sort_)
		{
			return GetByWin500_1000(win500_1000, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Win500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "win500_1000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin500_1000(int win500_1000, string sort_, TransactionManager tm_)
		{
			return GetByWin500_1000(win500_1000, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Win500_1000（字段） 查询
		/// </summary>
		/// /// <param name = "win500_1000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin500_1000(int win500_1000, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Win500_1000` = @Win500_1000", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Win500_1000", win500_1000, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByWin500_1000
		#region GetByWin1000_3000
		
		/// <summary>
		/// 按 Win1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "win1000_3000">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin1000_3000(int win1000_3000)
		{
			return GetByWin1000_3000(win1000_3000, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "win1000_3000">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin1000_3000(int win1000_3000, TransactionManager tm_)
		{
			return GetByWin1000_3000(win1000_3000, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "win1000_3000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin1000_3000(int win1000_3000, int top_)
		{
			return GetByWin1000_3000(win1000_3000, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "win1000_3000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin1000_3000(int win1000_3000, int top_, TransactionManager tm_)
		{
			return GetByWin1000_3000(win1000_3000, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "win1000_3000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin1000_3000(int win1000_3000, string sort_)
		{
			return GetByWin1000_3000(win1000_3000, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Win1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "win1000_3000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin1000_3000(int win1000_3000, string sort_, TransactionManager tm_)
		{
			return GetByWin1000_3000(win1000_3000, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Win1000_3000（字段） 查询
		/// </summary>
		/// /// <param name = "win1000_3000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin1000_3000(int win1000_3000, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Win1000_3000` = @Win1000_3000", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Win1000_3000", win1000_3000, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByWin1000_3000
		#region GetByWin3000_5000
		
		/// <summary>
		/// 按 Win3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "win3000_5000">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin3000_5000(int win3000_5000)
		{
			return GetByWin3000_5000(win3000_5000, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "win3000_5000">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin3000_5000(int win3000_5000, TransactionManager tm_)
		{
			return GetByWin3000_5000(win3000_5000, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "win3000_5000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin3000_5000(int win3000_5000, int top_)
		{
			return GetByWin3000_5000(win3000_5000, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "win3000_5000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin3000_5000(int win3000_5000, int top_, TransactionManager tm_)
		{
			return GetByWin3000_5000(win3000_5000, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "win3000_5000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin3000_5000(int win3000_5000, string sort_)
		{
			return GetByWin3000_5000(win3000_5000, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Win3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "win3000_5000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin3000_5000(int win3000_5000, string sort_, TransactionManager tm_)
		{
			return GetByWin3000_5000(win3000_5000, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Win3000_5000（字段） 查询
		/// </summary>
		/// /// <param name = "win3000_5000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin3000_5000(int win3000_5000, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Win3000_5000` = @Win3000_5000", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Win3000_5000", win3000_5000, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByWin3000_5000
		#region GetByWin5000_10000
		
		/// <summary>
		/// 按 Win5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "win5000_10000">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin5000_10000(int win5000_10000)
		{
			return GetByWin5000_10000(win5000_10000, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "win5000_10000">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin5000_10000(int win5000_10000, TransactionManager tm_)
		{
			return GetByWin5000_10000(win5000_10000, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "win5000_10000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin5000_10000(int win5000_10000, int top_)
		{
			return GetByWin5000_10000(win5000_10000, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "win5000_10000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin5000_10000(int win5000_10000, int top_, TransactionManager tm_)
		{
			return GetByWin5000_10000(win5000_10000, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "win5000_10000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin5000_10000(int win5000_10000, string sort_)
		{
			return GetByWin5000_10000(win5000_10000, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Win5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "win5000_10000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin5000_10000(int win5000_10000, string sort_, TransactionManager tm_)
		{
			return GetByWin5000_10000(win5000_10000, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Win5000_10000（字段） 查询
		/// </summary>
		/// /// <param name = "win5000_10000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin5000_10000(int win5000_10000, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Win5000_10000` = @Win5000_10000", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Win5000_10000", win5000_10000, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByWin5000_10000
		#region GetByWin10000_50000
		
		/// <summary>
		/// 按 Win10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "win10000_50000">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10000_50000(int win10000_50000)
		{
			return GetByWin10000_50000(win10000_50000, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "win10000_50000">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10000_50000(int win10000_50000, TransactionManager tm_)
		{
			return GetByWin10000_50000(win10000_50000, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "win10000_50000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10000_50000(int win10000_50000, int top_)
		{
			return GetByWin10000_50000(win10000_50000, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "win10000_50000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10000_50000(int win10000_50000, int top_, TransactionManager tm_)
		{
			return GetByWin10000_50000(win10000_50000, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "win10000_50000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10000_50000(int win10000_50000, string sort_)
		{
			return GetByWin10000_50000(win10000_50000, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Win10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "win10000_50000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10000_50000(int win10000_50000, string sort_, TransactionManager tm_)
		{
			return GetByWin10000_50000(win10000_50000, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Win10000_50000（字段） 查询
		/// </summary>
		/// /// <param name = "win10000_50000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin10000_50000(int win10000_50000, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Win10000_50000` = @Win10000_50000", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Win10000_50000", win10000_50000, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByWin10000_50000
		#region GetByWin50000
		
		/// <summary>
		/// 按 Win50000（字段） 查询
		/// </summary>
		/// /// <param name = "win50000">输10-100人数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin50000(int win50000)
		{
			return GetByWin50000(win50000, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win50000（字段） 查询
		/// </summary>
		/// /// <param name = "win50000">输10-100人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin50000(int win50000, TransactionManager tm_)
		{
			return GetByWin50000(win50000, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win50000（字段） 查询
		/// </summary>
		/// /// <param name = "win50000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin50000(int win50000, int top_)
		{
			return GetByWin50000(win50000, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Win50000（字段） 查询
		/// </summary>
		/// /// <param name = "win50000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin50000(int win50000, int top_, TransactionManager tm_)
		{
			return GetByWin50000(win50000, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Win50000（字段） 查询
		/// </summary>
		/// /// <param name = "win50000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin50000(int win50000, string sort_)
		{
			return GetByWin50000(win50000, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Win50000（字段） 查询
		/// </summary>
		/// /// <param name = "win50000">输10-100人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin50000(int win50000, string sort_, TransactionManager tm_)
		{
			return GetByWin50000(win50000, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Win50000（字段） 查询
		/// </summary>
		/// /// <param name = "win50000">输10-100人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByWin50000(int win50000, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Win50000` = @Win50000", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Win50000", win50000, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByWin50000
		#region GetByBetD1
		
		/// <summary>
		/// 按 BetD1（字段） 查询
		/// </summary>
		/// /// <param name = "betD1">下注一日留存</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetD1(float betD1)
		{
			return GetByBetD1(betD1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetD1（字段） 查询
		/// </summary>
		/// /// <param name = "betD1">下注一日留存</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetD1(float betD1, TransactionManager tm_)
		{
			return GetByBetD1(betD1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetD1（字段） 查询
		/// </summary>
		/// /// <param name = "betD1">下注一日留存</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetD1(float betD1, int top_)
		{
			return GetByBetD1(betD1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetD1（字段） 查询
		/// </summary>
		/// /// <param name = "betD1">下注一日留存</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetD1(float betD1, int top_, TransactionManager tm_)
		{
			return GetByBetD1(betD1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetD1（字段） 查询
		/// </summary>
		/// /// <param name = "betD1">下注一日留存</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetD1(float betD1, string sort_)
		{
			return GetByBetD1(betD1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetD1（字段） 查询
		/// </summary>
		/// /// <param name = "betD1">下注一日留存</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetD1(float betD1, string sort_, TransactionManager tm_)
		{
			return GetByBetD1(betD1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetD1（字段） 查询
		/// </summary>
		/// /// <param name = "betD1">下注一日留存</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByBetD1(float betD1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetD1` = @BetD1", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BetD1", betD1, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByBetD1
		#region GetByRMPbet
		
		/// <summary>
		/// 按 RMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rMPbet">注册用户复充人均下注</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRMPbet(float rMPbet)
		{
			return GetByRMPbet(rMPbet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rMPbet">注册用户复充人均下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRMPbet(float rMPbet, TransactionManager tm_)
		{
			return GetByRMPbet(rMPbet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rMPbet">注册用户复充人均下注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRMPbet(float rMPbet, int top_)
		{
			return GetByRMPbet(rMPbet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rMPbet">注册用户复充人均下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRMPbet(float rMPbet, int top_, TransactionManager tm_)
		{
			return GetByRMPbet(rMPbet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rMPbet">注册用户复充人均下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRMPbet(float rMPbet, string sort_)
		{
			return GetByRMPbet(rMPbet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rMPbet">注册用户复充人均下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRMPbet(float rMPbet, string sort_, TransactionManager tm_)
		{
			return GetByRMPbet(rMPbet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rMPbet">注册用户复充人均下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRMPbet(float rMPbet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RMPbet` = @RMPbet", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RMPbet", rMPbet, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRMPbet
		#region GetByRSPbet
		
		/// <summary>
		/// 按 RSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rSPbet">注册用户单充人均下注</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRSPbet(float rSPbet)
		{
			return GetByRSPbet(rSPbet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rSPbet">注册用户单充人均下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRSPbet(float rSPbet, TransactionManager tm_)
		{
			return GetByRSPbet(rSPbet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rSPbet">注册用户单充人均下注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRSPbet(float rSPbet, int top_)
		{
			return GetByRSPbet(rSPbet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rSPbet">注册用户单充人均下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRSPbet(float rSPbet, int top_, TransactionManager tm_)
		{
			return GetByRSPbet(rSPbet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rSPbet">注册用户单充人均下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRSPbet(float rSPbet, string sort_)
		{
			return GetByRSPbet(rSPbet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rSPbet">注册用户单充人均下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRSPbet(float rSPbet, string sort_, TransactionManager tm_)
		{
			return GetByRSPbet(rSPbet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "rSPbet">注册用户单充人均下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRSPbet(float rSPbet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RSPbet` = @RSPbet", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RSPbet", rSPbet, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRSPbet
		#region GetByPMPbet
		
		/// <summary>
		/// 按 PMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pMPbet">充值用户复充人均下注</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPMPbet(float pMPbet)
		{
			return GetByPMPbet(pMPbet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pMPbet">充值用户复充人均下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPMPbet(float pMPbet, TransactionManager tm_)
		{
			return GetByPMPbet(pMPbet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pMPbet">充值用户复充人均下注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPMPbet(float pMPbet, int top_)
		{
			return GetByPMPbet(pMPbet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pMPbet">充值用户复充人均下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPMPbet(float pMPbet, int top_, TransactionManager tm_)
		{
			return GetByPMPbet(pMPbet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pMPbet">充值用户复充人均下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPMPbet(float pMPbet, string sort_)
		{
			return GetByPMPbet(pMPbet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pMPbet">充值用户复充人均下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPMPbet(float pMPbet, string sort_, TransactionManager tm_)
		{
			return GetByPMPbet(pMPbet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PMPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pMPbet">充值用户复充人均下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPMPbet(float pMPbet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PMPbet` = @PMPbet", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PMPbet", pMPbet, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPMPbet
		#region GetByPSPbet
		
		/// <summary>
		/// 按 PSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pSPbet">充值用户单充人均下注</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPSPbet(float pSPbet)
		{
			return GetByPSPbet(pSPbet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pSPbet">充值用户单充人均下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPSPbet(float pSPbet, TransactionManager tm_)
		{
			return GetByPSPbet(pSPbet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pSPbet">充值用户单充人均下注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPSPbet(float pSPbet, int top_)
		{
			return GetByPSPbet(pSPbet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pSPbet">充值用户单充人均下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPSPbet(float pSPbet, int top_, TransactionManager tm_)
		{
			return GetByPSPbet(pSPbet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pSPbet">充值用户单充人均下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPSPbet(float pSPbet, string sort_)
		{
			return GetByPSPbet(pSPbet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pSPbet">充值用户单充人均下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPSPbet(float pSPbet, string sort_, TransactionManager tm_)
		{
			return GetByPSPbet(pSPbet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PSPbet（字段） 查询
		/// </summary>
		/// /// <param name = "pSPbet">充值用户单充人均下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByPSPbet(float pSPbet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PSPbet` = @PSPbet", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PSPbet", pSPbet, MySqlDbType.Float);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByPSPbet
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sr_channel_dayEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sr_channel_dayEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // Get
	}
	#endregion // MO
}
