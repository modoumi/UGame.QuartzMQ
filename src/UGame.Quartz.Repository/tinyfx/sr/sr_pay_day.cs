/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-10-25 10: 38:51
 ******************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data;
using MySql.Data.MySqlClient;
using System.Text;
using TinyFx.Data.MySql;

namespace UGame.Quartz.Repository
{
	#region EO
	/// <summary>
	/// 支付报表
	/// 【表 sr_pay_day 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sr_pay_dayEO : IRowMapper<Sr_pay_dayEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sr_pay_dayEO()
		{
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private DateTime _originalDayID;
		/// <summary>
		/// 【数据库中的原始主键 DayID 值的副本，用于主键值更新】
		/// </summary>
		public DateTime OriginalDayID
		{
			get { return _originalDayID; }
			set { HasOriginal = true; _originalDayID = value; }
		}
		
		private string _originalOperatorID;
		/// <summary>
		/// 【数据库中的原始主键 OperatorID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalOperatorID
		{
			get { return _originalOperatorID; }
			set { HasOriginal = true; _originalOperatorID = value; }
		}
		
		private string _originalBankID;
		/// <summary>
		/// 【数据库中的原始主键 BankID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalBankID
		{
			get { return _originalBankID; }
			set { HasOriginal = true; _originalBankID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DayID", DayID },  { "OperatorID", OperatorID },  { "BankID", BankID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 统计日
		/// 【主键 date】
		/// </summary>
		[DataMember(Order = 1)]
		public DateTime DayID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 货币类型（货币缩写USD）
		/// 【字段 varchar(10)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 银行ID
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string BankID { get; set; }
		/// <summary>
		/// 代收总额(充值)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 5)]
		public long PayTotal { get; set; }
		/// <summary>
		/// 总单数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int? OrderTotalNum { get; set; }
		/// <summary>
		/// 代收成功单数(充值)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int PaySuccesOrderNum { get; set; }
		/// <summary>
		/// 支付成功率(成功单数/总订单)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long PaySuccessRate { get; set; }
		/// <summary>
		/// 代收费用(充值手续费)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long PayOwnFee { get; set; }
		/// <summary>
		/// 代收单笔均额(代收总额/代收成功)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long PayAverage { get; set; }
		/// <summary>
		/// 代付总额(提现)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 11)]
		public long CashTotal { get; set; }
		/// <summary>
		/// 代付成功单数(提现)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int CashSuccesOrderNum { get; set; }
		/// <summary>
		/// 代付费用(提现)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 13)]
		public long CashUserFee { get; set; }
		/// <summary>
		/// 商户库存（充值-提现-手续费）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 14)]
		public long MerchantInventory { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sr_pay_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sr_pay_dayEO MapDataReader(IDataReader reader)
		{
		    Sr_pay_dayEO ret = new Sr_pay_dayEO();
			ret.DayID = reader.ToDateTime("DayID");
			ret.OriginalDayID = ret.DayID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.BankID = reader.ToString("BankID");
			ret.OriginalBankID = ret.BankID;
			ret.PayTotal = reader.ToInt64("PayTotal");
			ret.OrderTotalNum = reader.ToInt32N("OrderTotalNum");
			ret.PaySuccesOrderNum = reader.ToInt32("PaySuccesOrderNum");
			ret.PaySuccessRate = reader.ToInt64("PaySuccessRate");
			ret.PayOwnFee = reader.ToInt64("PayOwnFee");
			ret.PayAverage = reader.ToInt64("PayAverage");
			ret.CashTotal = reader.ToInt64("CashTotal");
			ret.CashSuccesOrderNum = reader.ToInt32("CashSuccesOrderNum");
			ret.CashUserFee = reader.ToInt64("CashUserFee");
			ret.MerchantInventory = reader.ToInt64("MerchantInventory");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 支付报表
	/// 【表 sr_pay_day 的操作类】
	/// </summary>
	[Obsolete]
	public class Sr_pay_dayMO : MySqlTableMO<Sr_pay_dayEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sr_pay_day`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sr_pay_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sr_pay_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sr_pay_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sr_pay_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sr_pay_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sr_pay_dayEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DayID`, `OperatorID`, `CurrencyID`, `BankID`, `PayTotal`, `OrderTotalNum`, `PaySuccesOrderNum`, `PaySuccessRate`, `PayOwnFee`, `PayAverage`, `CashTotal`, `CashSuccesOrderNum`, `CashUserFee`, `MerchantInventory`) VALUE (@DayID, @OperatorID, @CurrencyID, @BankID, @PayTotal, @OrderTotalNum, @PaySuccesOrderNum, @PaySuccessRate, @PayOwnFee, @PayAverage, @CashTotal, @CashSuccesOrderNum, @CashUserFee, @MerchantInventory);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", item.BankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayTotal", item.PayTotal, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderTotalNum", item.OrderTotalNum.HasValue ? item.OrderTotalNum.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@PaySuccesOrderNum", item.PaySuccesOrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@PaySuccessRate", item.PaySuccessRate, MySqlDbType.Int64),
				Database.CreateInParameter("@PayOwnFee", item.PayOwnFee, MySqlDbType.Int64),
				Database.CreateInParameter("@PayAverage", item.PayAverage, MySqlDbType.Int64),
				Database.CreateInParameter("@CashTotal", item.CashTotal, MySqlDbType.Int64),
				Database.CreateInParameter("@CashSuccesOrderNum", item.CashSuccesOrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@CashUserFee", item.CashUserFee, MySqlDbType.Int64),
				Database.CreateInParameter("@MerchantInventory", item.MerchantInventory, MySqlDbType.Int64),
			};
		}
		public int AddByBatch(IEnumerable<Sr_pay_dayEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sr_pay_dayEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sr_pay_dayEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DayID`, `OperatorID`, `CurrencyID`, `BankID`, `PayTotal`, `OrderTotalNum`, `PaySuccesOrderNum`, `PaySuccessRate`, `PayOwnFee`, `PayAverage`, `CashTotal`, `CashSuccesOrderNum`, `CashUserFee`, `MerchantInventory`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DayID.ToString("yyyy-MM-dd HH:mm:ss")}','{item.OperatorID}','{item.CurrencyID}','{item.BankID}',{item.PayTotal},{item.OrderTotalNum?.ToString()??null},{item.PaySuccesOrderNum},{item.PaySuccessRate},{item.PayOwnFee},{item.PayAverage},{item.CashTotal},{item.CashSuccesOrderNum},{item.CashUserFee},{item.MerchantInventory}),");
				if (count == batchCount)
				{
					count = 0;
					sql.Insert(0, insertSql);
					var ret = sql.ToString().TrimEnd(',');
					sql.Clear();
	                yield return ret;
				}
			}
			if (sql.Length > 0)
			{
	            sql.Insert(0, insertSql);
	            yield return sql.ToString().TrimEnd(',');
	        }
	    }
	    #endregion // Add
	    
		#region Remove
		#region RemoveByPK
		/// <summary>
		/// 按主键删除
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, operatorID, bankID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, operatorID, bankID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime dayID, string operatorID, string bankID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sr_pay_dayEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DayID, item.OperatorID, item.BankID, tm_);
		}
		public async Task<int> RemoveAsync(Sr_pay_dayEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DayID, item.OperatorID, item.BankID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByDayID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDayID(DateTime dayID, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIDData(dayID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDayIDAsync(DateTime dayID, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIDData(dayID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDayIDData(DateTime dayID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
		}
		#endregion // RemoveByDayID
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorIDData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrencyIDData(string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
		#region RemoveByBankID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBankID(string bankID, TransactionManager tm_ = null)
		{
			RepairRemoveByBankIDData(bankID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBankIDAsync(string bankID, TransactionManager tm_ = null)
		{
			RepairRemoveByBankIDData(bankID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBankIDData(string bankID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BankID` = @BankID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBankID
		#region RemoveByPayTotal
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payTotal">代收总额(充值)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayTotal(long payTotal, TransactionManager tm_ = null)
		{
			RepairRemoveByPayTotalData(payTotal, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayTotalAsync(long payTotal, TransactionManager tm_ = null)
		{
			RepairRemoveByPayTotalData(payTotal, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayTotalData(long payTotal, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayTotal` = @PayTotal";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayTotal", payTotal, MySqlDbType.Int64));
		}
		#endregion // RemoveByPayTotal
		#region RemoveByOrderTotalNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderTotalNum">总单数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderTotalNum(int? orderTotalNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderTotalNumData(orderTotalNum.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderTotalNumAsync(int? orderTotalNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderTotalNumData(orderTotalNum.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderTotalNumData(int? orderTotalNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (orderTotalNum.HasValue ? "`OrderTotalNum` = @OrderTotalNum" : "`OrderTotalNum` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (orderTotalNum.HasValue)
				paras_.Add(Database.CreateInParameter("@OrderTotalNum", orderTotalNum.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByOrderTotalNum
		#region RemoveByPaySuccesOrderNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "paySuccesOrderNum">代收成功单数(充值)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPaySuccesOrderNum(int paySuccesOrderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByPaySuccesOrderNumData(paySuccesOrderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPaySuccesOrderNumAsync(int paySuccesOrderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByPaySuccesOrderNumData(paySuccesOrderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPaySuccesOrderNumData(int paySuccesOrderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PaySuccesOrderNum` = @PaySuccesOrderNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaySuccesOrderNum", paySuccesOrderNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByPaySuccesOrderNum
		#region RemoveByPaySuccessRate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "paySuccessRate">支付成功率(成功单数/总订单)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPaySuccessRate(long paySuccessRate, TransactionManager tm_ = null)
		{
			RepairRemoveByPaySuccessRateData(paySuccessRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPaySuccessRateAsync(long paySuccessRate, TransactionManager tm_ = null)
		{
			RepairRemoveByPaySuccessRateData(paySuccessRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPaySuccessRateData(long paySuccessRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PaySuccessRate` = @PaySuccessRate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaySuccessRate", paySuccessRate, MySqlDbType.Int64));
		}
		#endregion // RemoveByPaySuccessRate
		#region RemoveByPayOwnFee
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payOwnFee">代收费用(充值手续费)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayOwnFee(long payOwnFee, TransactionManager tm_ = null)
		{
			RepairRemoveByPayOwnFeeData(payOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayOwnFeeAsync(long payOwnFee, TransactionManager tm_ = null)
		{
			RepairRemoveByPayOwnFeeData(payOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayOwnFeeData(long payOwnFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayOwnFee` = @PayOwnFee";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.Int64));
		}
		#endregion // RemoveByPayOwnFee
		#region RemoveByPayAverage
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payAverage">代收单笔均额(代收总额/代收成功)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayAverage(long payAverage, TransactionManager tm_ = null)
		{
			RepairRemoveByPayAverageData(payAverage, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayAverageAsync(long payAverage, TransactionManager tm_ = null)
		{
			RepairRemoveByPayAverageData(payAverage, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayAverageData(long payAverage, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayAverage` = @PayAverage";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAverage", payAverage, MySqlDbType.Int64));
		}
		#endregion // RemoveByPayAverage
		#region RemoveByCashTotal
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashTotal">代付总额(提现)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashTotal(long cashTotal, TransactionManager tm_ = null)
		{
			RepairRemoveByCashTotalData(cashTotal, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashTotalAsync(long cashTotal, TransactionManager tm_ = null)
		{
			RepairRemoveByCashTotalData(cashTotal, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashTotalData(long cashTotal, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashTotal` = @CashTotal";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashTotal", cashTotal, MySqlDbType.Int64));
		}
		#endregion // RemoveByCashTotal
		#region RemoveByCashSuccesOrderNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashSuccesOrderNum">代付成功单数(提现)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashSuccesOrderNum(int cashSuccesOrderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByCashSuccesOrderNumData(cashSuccesOrderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashSuccesOrderNumAsync(int cashSuccesOrderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByCashSuccesOrderNumData(cashSuccesOrderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashSuccesOrderNumData(int cashSuccesOrderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashSuccesOrderNum` = @CashSuccesOrderNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashSuccesOrderNum", cashSuccesOrderNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByCashSuccesOrderNum
		#region RemoveByCashUserFee
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashUserFee">代付费用(提现)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashUserFee(long cashUserFee, TransactionManager tm_ = null)
		{
			RepairRemoveByCashUserFeeData(cashUserFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashUserFeeAsync(long cashUserFee, TransactionManager tm_ = null)
		{
			RepairRemoveByCashUserFeeData(cashUserFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashUserFeeData(long cashUserFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashUserFee` = @CashUserFee";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.Int64));
		}
		#endregion // RemoveByCashUserFee
		#region RemoveByMerchantInventory
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "merchantInventory">商户库存（充值-提现-手续费）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMerchantInventory(long merchantInventory, TransactionManager tm_ = null)
		{
			RepairRemoveByMerchantInventoryData(merchantInventory, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMerchantInventoryAsync(long merchantInventory, TransactionManager tm_ = null)
		{
			RepairRemoveByMerchantInventoryData(merchantInventory, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMerchantInventoryData(long merchantInventory, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MerchantInventory` = @MerchantInventory";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MerchantInventory", merchantInventory, MySqlDbType.Int64));
		}
		#endregion // RemoveByMerchantInventory
		#endregion // RemoveByXXX
	    
		#region RemoveByFKOrUnique
		#endregion // RemoveByFKOrUnique
		#endregion //Remove
	    
		#region Put
		#region PutItem
		/// <summary>
		/// 更新实体到数据库
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(Sr_pay_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sr_pay_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sr_pay_dayEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayID` = @DayID, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `BankID` = @BankID, `PayTotal` = @PayTotal, `OrderTotalNum` = @OrderTotalNum, `PaySuccesOrderNum` = @PaySuccesOrderNum, `PaySuccessRate` = @PaySuccessRate, `PayOwnFee` = @PayOwnFee, `PayAverage` = @PayAverage, `CashTotal` = @CashTotal, `CashSuccesOrderNum` = @CashSuccesOrderNum, `CashUserFee` = @CashUserFee, `MerchantInventory` = @MerchantInventory WHERE `DayID` = @DayID_Original AND `OperatorID` = @OperatorID_Original AND `BankID` = @BankID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", item.BankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayTotal", item.PayTotal, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderTotalNum", item.OrderTotalNum.HasValue ? item.OrderTotalNum.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@PaySuccesOrderNum", item.PaySuccesOrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@PaySuccessRate", item.PaySuccessRate, MySqlDbType.Int64),
				Database.CreateInParameter("@PayOwnFee", item.PayOwnFee, MySqlDbType.Int64),
				Database.CreateInParameter("@PayAverage", item.PayAverage, MySqlDbType.Int64),
				Database.CreateInParameter("@CashTotal", item.CashTotal, MySqlDbType.Int64),
				Database.CreateInParameter("@CashSuccesOrderNum", item.CashSuccesOrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@CashUserFee", item.CashUserFee, MySqlDbType.Int64),
				Database.CreateInParameter("@MerchantInventory", item.MerchantInventory, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID_Original", item.HasOriginal ? item.OriginalDayID : item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID_Original", item.HasOriginal ? item.OriginalBankID : item.BankID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sr_pay_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sr_pay_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += await PutAsync(item, tm_);
			}
			return ret;
		}
		#endregion // PutItem
		
		#region PutByPK
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string operatorID, string bankID, string set_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", ConcatValues(values_, dayID, operatorID, bankID));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string operatorID, string bankID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", ConcatValues(values_, dayID, operatorID, bankID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string operatorID, string bankID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", tm_, ConcatValues(values_, dayID, operatorID, bankID));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string operatorID, string bankID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", tm_, ConcatValues(values_, dayID, operatorID, bankID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string operatorID, string bankID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string operatorID, string bankID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutDayID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDayID(DateTime dayID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayID` = @DayID";
			var parameter_ = Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDayIDAsync(DateTime dayID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayID` = @DayID";
			var parameter_ = Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDayID
		#region PutOperatorID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorID
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(DateTime dayID, string operatorID, string bankID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(dayID, operatorID, bankID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(DateTime dayID, string operatorID, string bankID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(dayID, operatorID, bankID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(DateTime dayID, string operatorID, string bankID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyID
		#region PutBankID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankID(string bankID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankID` = @BankID";
			var parameter_ = Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBankIDAsync(string bankID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankID` = @BankID";
			var parameter_ = Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBankID
		#region PutPayTotal
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// /// <param name = "payTotal">代收总额(充值)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayTotalByPK(DateTime dayID, string operatorID, string bankID, long payTotal, TransactionManager tm_ = null)
		{
			RepairPutPayTotalByPKData(dayID, operatorID, bankID, payTotal, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayTotalByPKAsync(DateTime dayID, string operatorID, string bankID, long payTotal, TransactionManager tm_ = null)
		{
			RepairPutPayTotalByPKData(dayID, operatorID, bankID, payTotal, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayTotalByPKData(DateTime dayID, string operatorID, string bankID, long payTotal, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayTotal` = @PayTotal  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayTotal", payTotal, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payTotal">代收总额(充值)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayTotal(long payTotal, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayTotal` = @PayTotal";
			var parameter_ = Database.CreateInParameter("@PayTotal", payTotal, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayTotalAsync(long payTotal, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayTotal` = @PayTotal";
			var parameter_ = Database.CreateInParameter("@PayTotal", payTotal, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayTotal
		#region PutOrderTotalNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// /// <param name = "orderTotalNum">总单数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderTotalNumByPK(DateTime dayID, string operatorID, string bankID, int? orderTotalNum, TransactionManager tm_ = null)
		{
			RepairPutOrderTotalNumByPKData(dayID, operatorID, bankID, orderTotalNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderTotalNumByPKAsync(DateTime dayID, string operatorID, string bankID, int? orderTotalNum, TransactionManager tm_ = null)
		{
			RepairPutOrderTotalNumByPKData(dayID, operatorID, bankID, orderTotalNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderTotalNumByPKData(DateTime dayID, string operatorID, string bankID, int? orderTotalNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderTotalNum` = @OrderTotalNum  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderTotalNum", orderTotalNum.HasValue ? orderTotalNum.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderTotalNum">总单数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderTotalNum(int? orderTotalNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderTotalNum` = @OrderTotalNum";
			var parameter_ = Database.CreateInParameter("@OrderTotalNum", orderTotalNum.HasValue ? orderTotalNum.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderTotalNumAsync(int? orderTotalNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderTotalNum` = @OrderTotalNum";
			var parameter_ = Database.CreateInParameter("@OrderTotalNum", orderTotalNum.HasValue ? orderTotalNum.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderTotalNum
		#region PutPaySuccesOrderNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// /// <param name = "paySuccesOrderNum">代收成功单数(充值)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPaySuccesOrderNumByPK(DateTime dayID, string operatorID, string bankID, int paySuccesOrderNum, TransactionManager tm_ = null)
		{
			RepairPutPaySuccesOrderNumByPKData(dayID, operatorID, bankID, paySuccesOrderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPaySuccesOrderNumByPKAsync(DateTime dayID, string operatorID, string bankID, int paySuccesOrderNum, TransactionManager tm_ = null)
		{
			RepairPutPaySuccesOrderNumByPKData(dayID, operatorID, bankID, paySuccesOrderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPaySuccesOrderNumByPKData(DateTime dayID, string operatorID, string bankID, int paySuccesOrderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PaySuccesOrderNum` = @PaySuccesOrderNum  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PaySuccesOrderNum", paySuccesOrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "paySuccesOrderNum">代收成功单数(充值)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPaySuccesOrderNum(int paySuccesOrderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PaySuccesOrderNum` = @PaySuccesOrderNum";
			var parameter_ = Database.CreateInParameter("@PaySuccesOrderNum", paySuccesOrderNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPaySuccesOrderNumAsync(int paySuccesOrderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PaySuccesOrderNum` = @PaySuccesOrderNum";
			var parameter_ = Database.CreateInParameter("@PaySuccesOrderNum", paySuccesOrderNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPaySuccesOrderNum
		#region PutPaySuccessRate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// /// <param name = "paySuccessRate">支付成功率(成功单数/总订单)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPaySuccessRateByPK(DateTime dayID, string operatorID, string bankID, long paySuccessRate, TransactionManager tm_ = null)
		{
			RepairPutPaySuccessRateByPKData(dayID, operatorID, bankID, paySuccessRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPaySuccessRateByPKAsync(DateTime dayID, string operatorID, string bankID, long paySuccessRate, TransactionManager tm_ = null)
		{
			RepairPutPaySuccessRateByPKData(dayID, operatorID, bankID, paySuccessRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPaySuccessRateByPKData(DateTime dayID, string operatorID, string bankID, long paySuccessRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PaySuccessRate` = @PaySuccessRate  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PaySuccessRate", paySuccessRate, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "paySuccessRate">支付成功率(成功单数/总订单)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPaySuccessRate(long paySuccessRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PaySuccessRate` = @PaySuccessRate";
			var parameter_ = Database.CreateInParameter("@PaySuccessRate", paySuccessRate, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPaySuccessRateAsync(long paySuccessRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PaySuccessRate` = @PaySuccessRate";
			var parameter_ = Database.CreateInParameter("@PaySuccessRate", paySuccessRate, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPaySuccessRate
		#region PutPayOwnFee
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// /// <param name = "payOwnFee">代收费用(充值手续费)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayOwnFeeByPK(DateTime dayID, string operatorID, string bankID, long payOwnFee, TransactionManager tm_ = null)
		{
			RepairPutPayOwnFeeByPKData(dayID, operatorID, bankID, payOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayOwnFeeByPKAsync(DateTime dayID, string operatorID, string bankID, long payOwnFee, TransactionManager tm_ = null)
		{
			RepairPutPayOwnFeeByPKData(dayID, operatorID, bankID, payOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayOwnFeeByPKData(DateTime dayID, string operatorID, string bankID, long payOwnFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayOwnFee` = @PayOwnFee  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payOwnFee">代收费用(充值手续费)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayOwnFee(long payOwnFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayOwnFee` = @PayOwnFee";
			var parameter_ = Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayOwnFeeAsync(long payOwnFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayOwnFee` = @PayOwnFee";
			var parameter_ = Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayOwnFee
		#region PutPayAverage
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// /// <param name = "payAverage">代收单笔均额(代收总额/代收成功)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAverageByPK(DateTime dayID, string operatorID, string bankID, long payAverage, TransactionManager tm_ = null)
		{
			RepairPutPayAverageByPKData(dayID, operatorID, bankID, payAverage, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayAverageByPKAsync(DateTime dayID, string operatorID, string bankID, long payAverage, TransactionManager tm_ = null)
		{
			RepairPutPayAverageByPKData(dayID, operatorID, bankID, payAverage, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayAverageByPKData(DateTime dayID, string operatorID, string bankID, long payAverage, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayAverage` = @PayAverage  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayAverage", payAverage, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payAverage">代收单笔均额(代收总额/代收成功)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAverage(long payAverage, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayAverage` = @PayAverage";
			var parameter_ = Database.CreateInParameter("@PayAverage", payAverage, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayAverageAsync(long payAverage, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayAverage` = @PayAverage";
			var parameter_ = Database.CreateInParameter("@PayAverage", payAverage, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayAverage
		#region PutCashTotal
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// /// <param name = "cashTotal">代付总额(提现)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashTotalByPK(DateTime dayID, string operatorID, string bankID, long cashTotal, TransactionManager tm_ = null)
		{
			RepairPutCashTotalByPKData(dayID, operatorID, bankID, cashTotal, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashTotalByPKAsync(DateTime dayID, string operatorID, string bankID, long cashTotal, TransactionManager tm_ = null)
		{
			RepairPutCashTotalByPKData(dayID, operatorID, bankID, cashTotal, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashTotalByPKData(DateTime dayID, string operatorID, string bankID, long cashTotal, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashTotal` = @CashTotal  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashTotal", cashTotal, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashTotal">代付总额(提现)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashTotal(long cashTotal, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashTotal` = @CashTotal";
			var parameter_ = Database.CreateInParameter("@CashTotal", cashTotal, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashTotalAsync(long cashTotal, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashTotal` = @CashTotal";
			var parameter_ = Database.CreateInParameter("@CashTotal", cashTotal, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashTotal
		#region PutCashSuccesOrderNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// /// <param name = "cashSuccesOrderNum">代付成功单数(提现)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashSuccesOrderNumByPK(DateTime dayID, string operatorID, string bankID, int cashSuccesOrderNum, TransactionManager tm_ = null)
		{
			RepairPutCashSuccesOrderNumByPKData(dayID, operatorID, bankID, cashSuccesOrderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashSuccesOrderNumByPKAsync(DateTime dayID, string operatorID, string bankID, int cashSuccesOrderNum, TransactionManager tm_ = null)
		{
			RepairPutCashSuccesOrderNumByPKData(dayID, operatorID, bankID, cashSuccesOrderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashSuccesOrderNumByPKData(DateTime dayID, string operatorID, string bankID, int cashSuccesOrderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashSuccesOrderNum` = @CashSuccesOrderNum  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashSuccesOrderNum", cashSuccesOrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashSuccesOrderNum">代付成功单数(提现)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashSuccesOrderNum(int cashSuccesOrderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashSuccesOrderNum` = @CashSuccesOrderNum";
			var parameter_ = Database.CreateInParameter("@CashSuccesOrderNum", cashSuccesOrderNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashSuccesOrderNumAsync(int cashSuccesOrderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashSuccesOrderNum` = @CashSuccesOrderNum";
			var parameter_ = Database.CreateInParameter("@CashSuccesOrderNum", cashSuccesOrderNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashSuccesOrderNum
		#region PutCashUserFee
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// /// <param name = "cashUserFee">代付费用(提现)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashUserFeeByPK(DateTime dayID, string operatorID, string bankID, long cashUserFee, TransactionManager tm_ = null)
		{
			RepairPutCashUserFeeByPKData(dayID, operatorID, bankID, cashUserFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashUserFeeByPKAsync(DateTime dayID, string operatorID, string bankID, long cashUserFee, TransactionManager tm_ = null)
		{
			RepairPutCashUserFeeByPKData(dayID, operatorID, bankID, cashUserFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashUserFeeByPKData(DateTime dayID, string operatorID, string bankID, long cashUserFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashUserFee` = @CashUserFee  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashUserFee">代付费用(提现)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashUserFee(long cashUserFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashUserFee` = @CashUserFee";
			var parameter_ = Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashUserFeeAsync(long cashUserFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashUserFee` = @CashUserFee";
			var parameter_ = Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashUserFee
		#region PutMerchantInventory
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// /// <param name = "merchantInventory">商户库存（充值-提现-手续费）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMerchantInventoryByPK(DateTime dayID, string operatorID, string bankID, long merchantInventory, TransactionManager tm_ = null)
		{
			RepairPutMerchantInventoryByPKData(dayID, operatorID, bankID, merchantInventory, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMerchantInventoryByPKAsync(DateTime dayID, string operatorID, string bankID, long merchantInventory, TransactionManager tm_ = null)
		{
			RepairPutMerchantInventoryByPKData(dayID, operatorID, bankID, merchantInventory, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMerchantInventoryByPKData(DateTime dayID, string operatorID, string bankID, long merchantInventory, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MerchantInventory` = @MerchantInventory  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MerchantInventory", merchantInventory, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "merchantInventory">商户库存（充值-提现-手续费）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMerchantInventory(long merchantInventory, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MerchantInventory` = @MerchantInventory";
			var parameter_ = Database.CreateInParameter("@MerchantInventory", merchantInventory, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMerchantInventoryAsync(long merchantInventory, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MerchantInventory` = @MerchantInventory";
			var parameter_ = Database.CreateInParameter("@MerchantInventory", merchantInventory, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMerchantInventory
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sr_pay_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.OperatorID, item.BankID) == null)
			{
				Add(item, tm);
			}
			else
			{
				Put(item, tm);
				ret = false;
			}
			return ret;
		}
		public async Task<bool> SetAsync(Sr_pay_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.OperatorID, item.BankID) == null)
			{
				await AddAsync(item, tm);
			}
			else
			{
				await PutAsync(item, tm);
				ret = false;
			}
			return ret;
		}
		
		#endregion // Set
		
		#region Get
		#region GetByPK
		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sr_pay_dayEO GetByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, operatorID, bankID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<Sr_pay_dayEO> GetByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, operatorID, bankID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime dayID, string operatorID, string bankID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 DayID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIDByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`DayID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<DateTime> GetDayIDByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`DayID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BankID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBankIDByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`BankID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<string> GetBankIDByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`BankID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayTotal（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayTotalByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PayTotal`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<long> GetPayTotalByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PayTotal`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderTotalNum（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetOrderTotalNumByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`OrderTotalNum`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<int?> GetOrderTotalNumByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`OrderTotalNum`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PaySuccesOrderNum（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPaySuccesOrderNumByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`PaySuccesOrderNum`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<int> GetPaySuccesOrderNumByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`PaySuccesOrderNum`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PaySuccessRate（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPaySuccessRateByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PaySuccessRate`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<long> GetPaySuccessRateByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PaySuccessRate`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayOwnFee（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayOwnFeeByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PayOwnFee`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<long> GetPayOwnFeeByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PayOwnFee`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayAverage（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayAverageByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PayAverage`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<long> GetPayAverageByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PayAverage`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashTotal（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCashTotalByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`CashTotal`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<long> GetCashTotalByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`CashTotal`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashSuccesOrderNum（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCashSuccesOrderNumByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CashSuccesOrderNum`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<int> GetCashSuccesOrderNumByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CashSuccesOrderNum`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashUserFee（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCashUserFeeByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`CashUserFee`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<long> GetCashUserFeeByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`CashUserFee`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MerchantInventory（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetMerchantInventoryByPK(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`MerchantInventory`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		public async Task<long> GetMerchantInventoryByPKAsync(DateTime dayID, string operatorID, string bankID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`MerchantInventory`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByDayID(DateTime dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByDayIDAsync(DateTime dayID)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByDayID(DateTime dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByDayIDAsync(DateTime dayID, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByDayID(DateTime dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByDayIDAsync(DateTime dayID, int top_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByDayID(DateTime dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByDayID(DateTime dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByDayID(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByDayID(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByBankID
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行ID</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByBankID(string bankID)
		{
			return GetByBankID(bankID, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByBankIDAsync(string bankID)
		{
			return await GetByBankIDAsync(bankID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByBankID(string bankID, TransactionManager tm_)
		{
			return GetByBankID(bankID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByBankIDAsync(string bankID, TransactionManager tm_)
		{
			return await GetByBankIDAsync(bankID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByBankID(string bankID, int top_)
		{
			return GetByBankID(bankID, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByBankIDAsync(string bankID, int top_)
		{
			return await GetByBankIDAsync(bankID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByBankID(string bankID, int top_, TransactionManager tm_)
		{
			return GetByBankID(bankID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByBankIDAsync(string bankID, int top_, TransactionManager tm_)
		{
			return await GetByBankIDAsync(bankID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByBankID(string bankID, string sort_)
		{
			return GetByBankID(bankID, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByBankIDAsync(string bankID, string sort_)
		{
			return await GetByBankIDAsync(bankID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByBankID(string bankID, string sort_, TransactionManager tm_)
		{
			return GetByBankID(bankID, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByBankIDAsync(string bankID, string sort_, TransactionManager tm_)
		{
			return await GetByBankIDAsync(bankID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByBankID(string bankID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BankID` = @BankID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByBankIDAsync(string bankID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BankID` = @BankID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByBankID
		#region GetByPayTotal
		
		/// <summary>
		/// 按 PayTotal（字段） 查询
		/// </summary>
		/// /// <param name = "payTotal">代收总额(充值)</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayTotal(long payTotal)
		{
			return GetByPayTotal(payTotal, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayTotalAsync(long payTotal)
		{
			return await GetByPayTotalAsync(payTotal, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayTotal（字段） 查询
		/// </summary>
		/// /// <param name = "payTotal">代收总额(充值)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayTotal(long payTotal, TransactionManager tm_)
		{
			return GetByPayTotal(payTotal, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayTotalAsync(long payTotal, TransactionManager tm_)
		{
			return await GetByPayTotalAsync(payTotal, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayTotal（字段） 查询
		/// </summary>
		/// /// <param name = "payTotal">代收总额(充值)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayTotal(long payTotal, int top_)
		{
			return GetByPayTotal(payTotal, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayTotalAsync(long payTotal, int top_)
		{
			return await GetByPayTotalAsync(payTotal, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayTotal（字段） 查询
		/// </summary>
		/// /// <param name = "payTotal">代收总额(充值)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayTotal(long payTotal, int top_, TransactionManager tm_)
		{
			return GetByPayTotal(payTotal, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayTotalAsync(long payTotal, int top_, TransactionManager tm_)
		{
			return await GetByPayTotalAsync(payTotal, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayTotal（字段） 查询
		/// </summary>
		/// /// <param name = "payTotal">代收总额(充值)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayTotal(long payTotal, string sort_)
		{
			return GetByPayTotal(payTotal, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayTotalAsync(long payTotal, string sort_)
		{
			return await GetByPayTotalAsync(payTotal, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayTotal（字段） 查询
		/// </summary>
		/// /// <param name = "payTotal">代收总额(充值)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayTotal(long payTotal, string sort_, TransactionManager tm_)
		{
			return GetByPayTotal(payTotal, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayTotalAsync(long payTotal, string sort_, TransactionManager tm_)
		{
			return await GetByPayTotalAsync(payTotal, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayTotal（字段） 查询
		/// </summary>
		/// /// <param name = "payTotal">代收总额(充值)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayTotal(long payTotal, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayTotal` = @PayTotal", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayTotal", payTotal, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayTotalAsync(long payTotal, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayTotal` = @PayTotal", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayTotal", payTotal, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByPayTotal
		#region GetByOrderTotalNum
		
		/// <summary>
		/// 按 OrderTotalNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderTotalNum">总单数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOrderTotalNum(int? orderTotalNum)
		{
			return GetByOrderTotalNum(orderTotalNum, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOrderTotalNumAsync(int? orderTotalNum)
		{
			return await GetByOrderTotalNumAsync(orderTotalNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderTotalNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderTotalNum">总单数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOrderTotalNum(int? orderTotalNum, TransactionManager tm_)
		{
			return GetByOrderTotalNum(orderTotalNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOrderTotalNumAsync(int? orderTotalNum, TransactionManager tm_)
		{
			return await GetByOrderTotalNumAsync(orderTotalNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderTotalNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderTotalNum">总单数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOrderTotalNum(int? orderTotalNum, int top_)
		{
			return GetByOrderTotalNum(orderTotalNum, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOrderTotalNumAsync(int? orderTotalNum, int top_)
		{
			return await GetByOrderTotalNumAsync(orderTotalNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderTotalNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderTotalNum">总单数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOrderTotalNum(int? orderTotalNum, int top_, TransactionManager tm_)
		{
			return GetByOrderTotalNum(orderTotalNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOrderTotalNumAsync(int? orderTotalNum, int top_, TransactionManager tm_)
		{
			return await GetByOrderTotalNumAsync(orderTotalNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderTotalNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderTotalNum">总单数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOrderTotalNum(int? orderTotalNum, string sort_)
		{
			return GetByOrderTotalNum(orderTotalNum, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOrderTotalNumAsync(int? orderTotalNum, string sort_)
		{
			return await GetByOrderTotalNumAsync(orderTotalNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderTotalNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderTotalNum">总单数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOrderTotalNum(int? orderTotalNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderTotalNum(orderTotalNum, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOrderTotalNumAsync(int? orderTotalNum, string sort_, TransactionManager tm_)
		{
			return await GetByOrderTotalNumAsync(orderTotalNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderTotalNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderTotalNum">总单数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByOrderTotalNum(int? orderTotalNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(orderTotalNum.HasValue ? "`OrderTotalNum` = @OrderTotalNum" : "`OrderTotalNum` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (orderTotalNum.HasValue)
				paras_.Add(Database.CreateInParameter("@OrderTotalNum", orderTotalNum.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByOrderTotalNumAsync(int? orderTotalNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(orderTotalNum.HasValue ? "`OrderTotalNum` = @OrderTotalNum" : "`OrderTotalNum` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (orderTotalNum.HasValue)
				paras_.Add(Database.CreateInParameter("@OrderTotalNum", orderTotalNum.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByOrderTotalNum
		#region GetByPaySuccesOrderNum
		
		/// <summary>
		/// 按 PaySuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccesOrderNum">代收成功单数(充值)</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccesOrderNum(int paySuccesOrderNum)
		{
			return GetByPaySuccesOrderNum(paySuccesOrderNum, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccesOrderNumAsync(int paySuccesOrderNum)
		{
			return await GetByPaySuccesOrderNumAsync(paySuccesOrderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PaySuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccesOrderNum">代收成功单数(充值)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccesOrderNum(int paySuccesOrderNum, TransactionManager tm_)
		{
			return GetByPaySuccesOrderNum(paySuccesOrderNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccesOrderNumAsync(int paySuccesOrderNum, TransactionManager tm_)
		{
			return await GetByPaySuccesOrderNumAsync(paySuccesOrderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PaySuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccesOrderNum">代收成功单数(充值)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccesOrderNum(int paySuccesOrderNum, int top_)
		{
			return GetByPaySuccesOrderNum(paySuccesOrderNum, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccesOrderNumAsync(int paySuccesOrderNum, int top_)
		{
			return await GetByPaySuccesOrderNumAsync(paySuccesOrderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PaySuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccesOrderNum">代收成功单数(充值)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccesOrderNum(int paySuccesOrderNum, int top_, TransactionManager tm_)
		{
			return GetByPaySuccesOrderNum(paySuccesOrderNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccesOrderNumAsync(int paySuccesOrderNum, int top_, TransactionManager tm_)
		{
			return await GetByPaySuccesOrderNumAsync(paySuccesOrderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PaySuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccesOrderNum">代收成功单数(充值)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccesOrderNum(int paySuccesOrderNum, string sort_)
		{
			return GetByPaySuccesOrderNum(paySuccesOrderNum, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccesOrderNumAsync(int paySuccesOrderNum, string sort_)
		{
			return await GetByPaySuccesOrderNumAsync(paySuccesOrderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PaySuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccesOrderNum">代收成功单数(充值)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccesOrderNum(int paySuccesOrderNum, string sort_, TransactionManager tm_)
		{
			return GetByPaySuccesOrderNum(paySuccesOrderNum, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccesOrderNumAsync(int paySuccesOrderNum, string sort_, TransactionManager tm_)
		{
			return await GetByPaySuccesOrderNumAsync(paySuccesOrderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PaySuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccesOrderNum">代收成功单数(充值)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccesOrderNum(int paySuccesOrderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PaySuccesOrderNum` = @PaySuccesOrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaySuccesOrderNum", paySuccesOrderNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccesOrderNumAsync(int paySuccesOrderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PaySuccesOrderNum` = @PaySuccesOrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaySuccesOrderNum", paySuccesOrderNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByPaySuccesOrderNum
		#region GetByPaySuccessRate
		
		/// <summary>
		/// 按 PaySuccessRate（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccessRate">支付成功率(成功单数/总订单)</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccessRate(long paySuccessRate)
		{
			return GetByPaySuccessRate(paySuccessRate, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccessRateAsync(long paySuccessRate)
		{
			return await GetByPaySuccessRateAsync(paySuccessRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PaySuccessRate（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccessRate">支付成功率(成功单数/总订单)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccessRate(long paySuccessRate, TransactionManager tm_)
		{
			return GetByPaySuccessRate(paySuccessRate, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccessRateAsync(long paySuccessRate, TransactionManager tm_)
		{
			return await GetByPaySuccessRateAsync(paySuccessRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PaySuccessRate（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccessRate">支付成功率(成功单数/总订单)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccessRate(long paySuccessRate, int top_)
		{
			return GetByPaySuccessRate(paySuccessRate, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccessRateAsync(long paySuccessRate, int top_)
		{
			return await GetByPaySuccessRateAsync(paySuccessRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PaySuccessRate（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccessRate">支付成功率(成功单数/总订单)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccessRate(long paySuccessRate, int top_, TransactionManager tm_)
		{
			return GetByPaySuccessRate(paySuccessRate, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccessRateAsync(long paySuccessRate, int top_, TransactionManager tm_)
		{
			return await GetByPaySuccessRateAsync(paySuccessRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PaySuccessRate（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccessRate">支付成功率(成功单数/总订单)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccessRate(long paySuccessRate, string sort_)
		{
			return GetByPaySuccessRate(paySuccessRate, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccessRateAsync(long paySuccessRate, string sort_)
		{
			return await GetByPaySuccessRateAsync(paySuccessRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PaySuccessRate（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccessRate">支付成功率(成功单数/总订单)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccessRate(long paySuccessRate, string sort_, TransactionManager tm_)
		{
			return GetByPaySuccessRate(paySuccessRate, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccessRateAsync(long paySuccessRate, string sort_, TransactionManager tm_)
		{
			return await GetByPaySuccessRateAsync(paySuccessRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PaySuccessRate（字段） 查询
		/// </summary>
		/// /// <param name = "paySuccessRate">支付成功率(成功单数/总订单)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPaySuccessRate(long paySuccessRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PaySuccessRate` = @PaySuccessRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaySuccessRate", paySuccessRate, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPaySuccessRateAsync(long paySuccessRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PaySuccessRate` = @PaySuccessRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaySuccessRate", paySuccessRate, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByPaySuccessRate
		#region GetByPayOwnFee
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">代收费用(充值手续费)</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayOwnFee(long payOwnFee)
		{
			return GetByPayOwnFee(payOwnFee, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayOwnFeeAsync(long payOwnFee)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">代收费用(充值手续费)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayOwnFee(long payOwnFee, TransactionManager tm_)
		{
			return GetByPayOwnFee(payOwnFee, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayOwnFeeAsync(long payOwnFee, TransactionManager tm_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">代收费用(充值手续费)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayOwnFee(long payOwnFee, int top_)
		{
			return GetByPayOwnFee(payOwnFee, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayOwnFeeAsync(long payOwnFee, int top_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">代收费用(充值手续费)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayOwnFee(long payOwnFee, int top_, TransactionManager tm_)
		{
			return GetByPayOwnFee(payOwnFee, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayOwnFeeAsync(long payOwnFee, int top_, TransactionManager tm_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">代收费用(充值手续费)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayOwnFee(long payOwnFee, string sort_)
		{
			return GetByPayOwnFee(payOwnFee, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayOwnFeeAsync(long payOwnFee, string sort_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">代收费用(充值手续费)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayOwnFee(long payOwnFee, string sort_, TransactionManager tm_)
		{
			return GetByPayOwnFee(payOwnFee, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayOwnFeeAsync(long payOwnFee, string sort_, TransactionManager tm_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">代收费用(充值手续费)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayOwnFee(long payOwnFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayOwnFee` = @PayOwnFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayOwnFeeAsync(long payOwnFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayOwnFee` = @PayOwnFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByPayOwnFee
		#region GetByPayAverage
		
		/// <summary>
		/// 按 PayAverage（字段） 查询
		/// </summary>
		/// /// <param name = "payAverage">代收单笔均额(代收总额/代收成功)</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayAverage(long payAverage)
		{
			return GetByPayAverage(payAverage, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayAverageAsync(long payAverage)
		{
			return await GetByPayAverageAsync(payAverage, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAverage（字段） 查询
		/// </summary>
		/// /// <param name = "payAverage">代收单笔均额(代收总额/代收成功)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayAverage(long payAverage, TransactionManager tm_)
		{
			return GetByPayAverage(payAverage, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayAverageAsync(long payAverage, TransactionManager tm_)
		{
			return await GetByPayAverageAsync(payAverage, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAverage（字段） 查询
		/// </summary>
		/// /// <param name = "payAverage">代收单笔均额(代收总额/代收成功)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayAverage(long payAverage, int top_)
		{
			return GetByPayAverage(payAverage, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayAverageAsync(long payAverage, int top_)
		{
			return await GetByPayAverageAsync(payAverage, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAverage（字段） 查询
		/// </summary>
		/// /// <param name = "payAverage">代收单笔均额(代收总额/代收成功)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayAverage(long payAverage, int top_, TransactionManager tm_)
		{
			return GetByPayAverage(payAverage, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayAverageAsync(long payAverage, int top_, TransactionManager tm_)
		{
			return await GetByPayAverageAsync(payAverage, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAverage（字段） 查询
		/// </summary>
		/// /// <param name = "payAverage">代收单笔均额(代收总额/代收成功)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayAverage(long payAverage, string sort_)
		{
			return GetByPayAverage(payAverage, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayAverageAsync(long payAverage, string sort_)
		{
			return await GetByPayAverageAsync(payAverage, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayAverage（字段） 查询
		/// </summary>
		/// /// <param name = "payAverage">代收单笔均额(代收总额/代收成功)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayAverage(long payAverage, string sort_, TransactionManager tm_)
		{
			return GetByPayAverage(payAverage, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayAverageAsync(long payAverage, string sort_, TransactionManager tm_)
		{
			return await GetByPayAverageAsync(payAverage, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayAverage（字段） 查询
		/// </summary>
		/// /// <param name = "payAverage">代收单笔均额(代收总额/代收成功)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByPayAverage(long payAverage, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAverage` = @PayAverage", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAverage", payAverage, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByPayAverageAsync(long payAverage, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAverage` = @PayAverage", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAverage", payAverage, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByPayAverage
		#region GetByCashTotal
		
		/// <summary>
		/// 按 CashTotal（字段） 查询
		/// </summary>
		/// /// <param name = "cashTotal">代付总额(提现)</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashTotal(long cashTotal)
		{
			return GetByCashTotal(cashTotal, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashTotalAsync(long cashTotal)
		{
			return await GetByCashTotalAsync(cashTotal, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashTotal（字段） 查询
		/// </summary>
		/// /// <param name = "cashTotal">代付总额(提现)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashTotal(long cashTotal, TransactionManager tm_)
		{
			return GetByCashTotal(cashTotal, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashTotalAsync(long cashTotal, TransactionManager tm_)
		{
			return await GetByCashTotalAsync(cashTotal, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashTotal（字段） 查询
		/// </summary>
		/// /// <param name = "cashTotal">代付总额(提现)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashTotal(long cashTotal, int top_)
		{
			return GetByCashTotal(cashTotal, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashTotalAsync(long cashTotal, int top_)
		{
			return await GetByCashTotalAsync(cashTotal, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashTotal（字段） 查询
		/// </summary>
		/// /// <param name = "cashTotal">代付总额(提现)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashTotal(long cashTotal, int top_, TransactionManager tm_)
		{
			return GetByCashTotal(cashTotal, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashTotalAsync(long cashTotal, int top_, TransactionManager tm_)
		{
			return await GetByCashTotalAsync(cashTotal, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashTotal（字段） 查询
		/// </summary>
		/// /// <param name = "cashTotal">代付总额(提现)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashTotal(long cashTotal, string sort_)
		{
			return GetByCashTotal(cashTotal, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashTotalAsync(long cashTotal, string sort_)
		{
			return await GetByCashTotalAsync(cashTotal, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashTotal（字段） 查询
		/// </summary>
		/// /// <param name = "cashTotal">代付总额(提现)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashTotal(long cashTotal, string sort_, TransactionManager tm_)
		{
			return GetByCashTotal(cashTotal, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashTotalAsync(long cashTotal, string sort_, TransactionManager tm_)
		{
			return await GetByCashTotalAsync(cashTotal, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashTotal（字段） 查询
		/// </summary>
		/// /// <param name = "cashTotal">代付总额(提现)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashTotal(long cashTotal, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashTotal` = @CashTotal", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashTotal", cashTotal, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashTotalAsync(long cashTotal, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashTotal` = @CashTotal", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashTotal", cashTotal, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByCashTotal
		#region GetByCashSuccesOrderNum
		
		/// <summary>
		/// 按 CashSuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashSuccesOrderNum">代付成功单数(提现)</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashSuccesOrderNum(int cashSuccesOrderNum)
		{
			return GetByCashSuccesOrderNum(cashSuccesOrderNum, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashSuccesOrderNumAsync(int cashSuccesOrderNum)
		{
			return await GetByCashSuccesOrderNumAsync(cashSuccesOrderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashSuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashSuccesOrderNum">代付成功单数(提现)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashSuccesOrderNum(int cashSuccesOrderNum, TransactionManager tm_)
		{
			return GetByCashSuccesOrderNum(cashSuccesOrderNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashSuccesOrderNumAsync(int cashSuccesOrderNum, TransactionManager tm_)
		{
			return await GetByCashSuccesOrderNumAsync(cashSuccesOrderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashSuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashSuccesOrderNum">代付成功单数(提现)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashSuccesOrderNum(int cashSuccesOrderNum, int top_)
		{
			return GetByCashSuccesOrderNum(cashSuccesOrderNum, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashSuccesOrderNumAsync(int cashSuccesOrderNum, int top_)
		{
			return await GetByCashSuccesOrderNumAsync(cashSuccesOrderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashSuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashSuccesOrderNum">代付成功单数(提现)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashSuccesOrderNum(int cashSuccesOrderNum, int top_, TransactionManager tm_)
		{
			return GetByCashSuccesOrderNum(cashSuccesOrderNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashSuccesOrderNumAsync(int cashSuccesOrderNum, int top_, TransactionManager tm_)
		{
			return await GetByCashSuccesOrderNumAsync(cashSuccesOrderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashSuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashSuccesOrderNum">代付成功单数(提现)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashSuccesOrderNum(int cashSuccesOrderNum, string sort_)
		{
			return GetByCashSuccesOrderNum(cashSuccesOrderNum, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashSuccesOrderNumAsync(int cashSuccesOrderNum, string sort_)
		{
			return await GetByCashSuccesOrderNumAsync(cashSuccesOrderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashSuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashSuccesOrderNum">代付成功单数(提现)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashSuccesOrderNum(int cashSuccesOrderNum, string sort_, TransactionManager tm_)
		{
			return GetByCashSuccesOrderNum(cashSuccesOrderNum, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashSuccesOrderNumAsync(int cashSuccesOrderNum, string sort_, TransactionManager tm_)
		{
			return await GetByCashSuccesOrderNumAsync(cashSuccesOrderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashSuccesOrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashSuccesOrderNum">代付成功单数(提现)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashSuccesOrderNum(int cashSuccesOrderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashSuccesOrderNum` = @CashSuccesOrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashSuccesOrderNum", cashSuccesOrderNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashSuccesOrderNumAsync(int cashSuccesOrderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashSuccesOrderNum` = @CashSuccesOrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashSuccesOrderNum", cashSuccesOrderNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByCashSuccesOrderNum
		#region GetByCashUserFee
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">代付费用(提现)</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashUserFee(long cashUserFee)
		{
			return GetByCashUserFee(cashUserFee, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashUserFeeAsync(long cashUserFee)
		{
			return await GetByCashUserFeeAsync(cashUserFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">代付费用(提现)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashUserFee(long cashUserFee, TransactionManager tm_)
		{
			return GetByCashUserFee(cashUserFee, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashUserFeeAsync(long cashUserFee, TransactionManager tm_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">代付费用(提现)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashUserFee(long cashUserFee, int top_)
		{
			return GetByCashUserFee(cashUserFee, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashUserFeeAsync(long cashUserFee, int top_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">代付费用(提现)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashUserFee(long cashUserFee, int top_, TransactionManager tm_)
		{
			return GetByCashUserFee(cashUserFee, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashUserFeeAsync(long cashUserFee, int top_, TransactionManager tm_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">代付费用(提现)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashUserFee(long cashUserFee, string sort_)
		{
			return GetByCashUserFee(cashUserFee, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashUserFeeAsync(long cashUserFee, string sort_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">代付费用(提现)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashUserFee(long cashUserFee, string sort_, TransactionManager tm_)
		{
			return GetByCashUserFee(cashUserFee, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashUserFeeAsync(long cashUserFee, string sort_, TransactionManager tm_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">代付费用(提现)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByCashUserFee(long cashUserFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashUserFee` = @CashUserFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByCashUserFeeAsync(long cashUserFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashUserFee` = @CashUserFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByCashUserFee
		#region GetByMerchantInventory
		
		/// <summary>
		/// 按 MerchantInventory（字段） 查询
		/// </summary>
		/// /// <param name = "merchantInventory">商户库存（充值-提现-手续费）</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByMerchantInventory(long merchantInventory)
		{
			return GetByMerchantInventory(merchantInventory, 0, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByMerchantInventoryAsync(long merchantInventory)
		{
			return await GetByMerchantInventoryAsync(merchantInventory, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MerchantInventory（字段） 查询
		/// </summary>
		/// /// <param name = "merchantInventory">商户库存（充值-提现-手续费）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByMerchantInventory(long merchantInventory, TransactionManager tm_)
		{
			return GetByMerchantInventory(merchantInventory, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByMerchantInventoryAsync(long merchantInventory, TransactionManager tm_)
		{
			return await GetByMerchantInventoryAsync(merchantInventory, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MerchantInventory（字段） 查询
		/// </summary>
		/// /// <param name = "merchantInventory">商户库存（充值-提现-手续费）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByMerchantInventory(long merchantInventory, int top_)
		{
			return GetByMerchantInventory(merchantInventory, top_, string.Empty, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByMerchantInventoryAsync(long merchantInventory, int top_)
		{
			return await GetByMerchantInventoryAsync(merchantInventory, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MerchantInventory（字段） 查询
		/// </summary>
		/// /// <param name = "merchantInventory">商户库存（充值-提现-手续费）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByMerchantInventory(long merchantInventory, int top_, TransactionManager tm_)
		{
			return GetByMerchantInventory(merchantInventory, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByMerchantInventoryAsync(long merchantInventory, int top_, TransactionManager tm_)
		{
			return await GetByMerchantInventoryAsync(merchantInventory, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MerchantInventory（字段） 查询
		/// </summary>
		/// /// <param name = "merchantInventory">商户库存（充值-提现-手续费）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByMerchantInventory(long merchantInventory, string sort_)
		{
			return GetByMerchantInventory(merchantInventory, 0, sort_, null);
		}
		public async Task<List<Sr_pay_dayEO>> GetByMerchantInventoryAsync(long merchantInventory, string sort_)
		{
			return await GetByMerchantInventoryAsync(merchantInventory, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MerchantInventory（字段） 查询
		/// </summary>
		/// /// <param name = "merchantInventory">商户库存（充值-提现-手续费）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByMerchantInventory(long merchantInventory, string sort_, TransactionManager tm_)
		{
			return GetByMerchantInventory(merchantInventory, 0, sort_, tm_);
		}
		public async Task<List<Sr_pay_dayEO>> GetByMerchantInventoryAsync(long merchantInventory, string sort_, TransactionManager tm_)
		{
			return await GetByMerchantInventoryAsync(merchantInventory, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MerchantInventory（字段） 查询
		/// </summary>
		/// /// <param name = "merchantInventory">商户库存（充值-提现-手续费）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_pay_dayEO> GetByMerchantInventory(long merchantInventory, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MerchantInventory` = @MerchantInventory", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MerchantInventory", merchantInventory, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		public async Task<List<Sr_pay_dayEO>> GetByMerchantInventoryAsync(long merchantInventory, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MerchantInventory` = @MerchantInventory", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MerchantInventory", merchantInventory, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_pay_dayEO.MapDataReader);
		}
		#endregion // GetByMerchantInventory
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
