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
	/// 银行支付方式每日统计
	/// 【表 sr_oper_bank_paytype_day 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sr_oper_bank_paytype_dayEO : IRowMapper<Sr_oper_bank_paytype_dayEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sr_oper_bank_paytype_dayEO()
		{
			this.PaytypeID = 0;
			this.PayUsers = 0;
			this.CashUsers = 0;
			this.PayOwnFee = 0.00m;
			this.PayUserFee = 0.00m;
			this.PayAmount = 0;
			this.CashAmount = 0;
			this.CashOwnFee = 0.00m;
			this.CashUserFee = 0.00m;
			this.RecDate = DateTime.Now;
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
		
		private int _originalPaytypeID;
		/// <summary>
		/// 【数据库中的原始主键 PaytypeID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalPaytypeID
		{
			get { return _originalPaytypeID; }
			set { HasOriginal = true; _originalPaytypeID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DayID", DayID },  { "OperatorID", OperatorID },  { "BankID", BankID },  { "PaytypeID", PaytypeID }, };
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
		/// 银行编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string BankID { get; set; }
		/// <summary>
		/// 支付方式0-综合1-visa2-spei
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int PaytypeID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 5)]
		public string CountryID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 6)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 充值用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int PayUsers { get; set; }
		/// <summary>
		/// 提现用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int CashUsers { get; set; }
		/// <summary>
		/// 充值我方手续费
		/// 【字段 decimal(20,2)】
		/// </summary>
		[DataMember(Order = 9)]
		public decimal PayOwnFee { get; set; }
		/// <summary>
		/// 充值用户手续费
		/// 【字段 decimal(20,2)】
		/// </summary>
		[DataMember(Order = 10)]
		public decimal PayUserFee { get; set; }
		/// <summary>
		/// 充值数量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 11)]
		public long PayAmount { get; set; }
		/// <summary>
		/// 提现数量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 12)]
		public long CashAmount { get; set; }
		/// <summary>
		/// 提现我方手续费
		/// 【字段 decimal(20,2)】
		/// </summary>
		[DataMember(Order = 13)]
		public decimal CashOwnFee { get; set; }
		/// <summary>
		/// 提现用户手续费
		/// 【字段 decimal(20,2)】
		/// </summary>
		[DataMember(Order = 14)]
		public decimal CashUserFee { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 15)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sr_oper_bank_paytype_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sr_oper_bank_paytype_dayEO MapDataReader(IDataReader reader)
		{
		    Sr_oper_bank_paytype_dayEO ret = new Sr_oper_bank_paytype_dayEO();
			ret.DayID = reader.ToDateTime("DayID");
			ret.OriginalDayID = ret.DayID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.BankID = reader.ToString("BankID");
			ret.OriginalBankID = ret.BankID;
			ret.PaytypeID = reader.ToInt32("PaytypeID");
			ret.OriginalPaytypeID = ret.PaytypeID;
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.PayUsers = reader.ToInt32("PayUsers");
			ret.CashUsers = reader.ToInt32("CashUsers");
			ret.PayOwnFee = reader.ToDecimal("PayOwnFee");
			ret.PayUserFee = reader.ToDecimal("PayUserFee");
			ret.PayAmount = reader.ToInt64("PayAmount");
			ret.CashAmount = reader.ToInt64("CashAmount");
			ret.CashOwnFee = reader.ToDecimal("CashOwnFee");
			ret.CashUserFee = reader.ToDecimal("CashUserFee");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 银行支付方式每日统计
	/// 【表 sr_oper_bank_paytype_day 的操作类】
	/// </summary>
	[Obsolete]
	public class Sr_oper_bank_paytype_dayMO : MySqlTableMO<Sr_oper_bank_paytype_dayEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sr_oper_bank_paytype_day`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sr_oper_bank_paytype_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sr_oper_bank_paytype_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sr_oper_bank_paytype_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sr_oper_bank_paytype_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sr_oper_bank_paytype_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sr_oper_bank_paytype_dayEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DayID`, `OperatorID`, `BankID`, `PaytypeID`, `CountryID`, `CurrencyID`, `PayUsers`, `CashUsers`, `PayOwnFee`, `PayUserFee`, `PayAmount`, `CashAmount`, `CashOwnFee`, `CashUserFee`, `RecDate`) VALUE (@DayID, @OperatorID, @BankID, @PaytypeID, @CountryID, @CurrencyID, @PayUsers, @CashUsers, @PayOwnFee, @PayUserFee, @PayAmount, @CashAmount, @CashOwnFee, @CashUserFee, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", item.BankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", item.PaytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayUsers", item.PayUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@CashUsers", item.CashUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@PayOwnFee", item.PayOwnFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@PayUserFee", item.PayUserFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@PayAmount", item.PayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@CashAmount", item.CashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@CashOwnFee", item.CashOwnFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@CashUserFee", item.CashUserFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sr_oper_bank_paytype_dayEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sr_oper_bank_paytype_dayEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sr_oper_bank_paytype_dayEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DayID`, `OperatorID`, `BankID`, `PaytypeID`, `CountryID`, `CurrencyID`, `PayUsers`, `CashUsers`, `PayOwnFee`, `PayUserFee`, `PayAmount`, `CashAmount`, `CashOwnFee`, `CashUserFee`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DayID.ToString("yyyy-MM-dd HH:mm:ss")}','{item.OperatorID}','{item.BankID}',{item.PaytypeID},'{item.CountryID}','{item.CurrencyID}',{item.PayUsers},{item.CashUsers},{item.PayOwnFee},{item.PayUserFee},{item.PayAmount},{item.CashAmount},{item.CashOwnFee},{item.CashUserFee},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, operatorID, bankID, paytypeID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, operatorID, bankID, paytypeID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sr_oper_bank_paytype_dayEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DayID, item.OperatorID, item.BankID, item.PaytypeID, tm_);
		}
		public async Task<int> RemoveAsync(Sr_oper_bank_paytype_dayEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DayID, item.OperatorID, item.BankID, item.PaytypeID, tm_);
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
		#region RemoveByBankID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
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
		#region RemoveByPaytypeID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPaytypeID(int paytypeID, TransactionManager tm_ = null)
		{
			RepairRemoveByPaytypeIDData(paytypeID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPaytypeIDAsync(int paytypeID, TransactionManager tm_ = null)
		{
			RepairRemoveByPaytypeIDData(paytypeID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPaytypeIDData(int paytypeID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32));
		}
		#endregion // RemoveByPaytypeID
		#region RemoveByCountryID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryID(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryIDData(string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryID
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
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
			sql_ = $"DELETE FROM {TableName} WHERE " + (currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
		#region RemoveByPayUsers
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payUsers">充值用户数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayUsers(int payUsers, TransactionManager tm_ = null)
		{
			RepairRemoveByPayUsersData(payUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayUsersAsync(int payUsers, TransactionManager tm_ = null)
		{
			RepairRemoveByPayUsersData(payUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayUsersData(int payUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayUsers` = @PayUsers";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayUsers", payUsers, MySqlDbType.Int32));
		}
		#endregion // RemoveByPayUsers
		#region RemoveByCashUsers
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashUsers(int cashUsers, TransactionManager tm_ = null)
		{
			RepairRemoveByCashUsersData(cashUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashUsersAsync(int cashUsers, TransactionManager tm_ = null)
		{
			RepairRemoveByCashUsersData(cashUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashUsersData(int cashUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashUsers` = @CashUsers";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashUsers", cashUsers, MySqlDbType.Int32));
		}
		#endregion // RemoveByCashUsers
		#region RemoveByPayOwnFee
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayOwnFee(decimal payOwnFee, TransactionManager tm_ = null)
		{
			RepairRemoveByPayOwnFeeData(payOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayOwnFeeAsync(decimal payOwnFee, TransactionManager tm_ = null)
		{
			RepairRemoveByPayOwnFeeData(payOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayOwnFeeData(decimal payOwnFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayOwnFee` = @PayOwnFee";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal));
		}
		#endregion // RemoveByPayOwnFee
		#region RemoveByPayUserFee
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayUserFee(decimal payUserFee, TransactionManager tm_ = null)
		{
			RepairRemoveByPayUserFeeData(payUserFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayUserFeeAsync(decimal payUserFee, TransactionManager tm_ = null)
		{
			RepairRemoveByPayUserFeeData(payUserFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayUserFeeData(decimal payUserFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayUserFee` = @PayUserFee";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal));
		}
		#endregion // RemoveByPayUserFee
		#region RemoveByPayAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayAmount(long payAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByPayAmountData(payAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayAmountAsync(long payAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByPayAmountData(payAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayAmountData(long payAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayAmount` = @PayAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByPayAmount
		#region RemoveByCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashAmount(long cashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByCashAmountData(cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashAmountAsync(long cashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByCashAmountData(cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashAmountData(long cashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashAmount` = @CashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByCashAmount
		#region RemoveByCashOwnFee
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashOwnFee(decimal cashOwnFee, TransactionManager tm_ = null)
		{
			RepairRemoveByCashOwnFeeData(cashOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashOwnFeeAsync(decimal cashOwnFee, TransactionManager tm_ = null)
		{
			RepairRemoveByCashOwnFeeData(cashOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashOwnFeeData(decimal cashOwnFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashOwnFee` = @CashOwnFee";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashOwnFee", cashOwnFee, MySqlDbType.NewDecimal));
		}
		#endregion // RemoveByCashOwnFee
		#region RemoveByCashUserFee
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashUserFee(decimal cashUserFee, TransactionManager tm_ = null)
		{
			RepairRemoveByCashUserFeeData(cashUserFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashUserFeeAsync(decimal cashUserFee, TransactionManager tm_ = null)
		{
			RepairRemoveByCashUserFeeData(cashUserFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashUserFeeData(decimal cashUserFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashUserFee` = @CashUserFee";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal));
		}
		#endregion // RemoveByCashUserFee
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RecDate` = @RecDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
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
		public int Put(Sr_oper_bank_paytype_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sr_oper_bank_paytype_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sr_oper_bank_paytype_dayEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayID` = @DayID, `OperatorID` = @OperatorID, `BankID` = @BankID, `PaytypeID` = @PaytypeID, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `PayUsers` = @PayUsers, `CashUsers` = @CashUsers, `PayOwnFee` = @PayOwnFee, `PayUserFee` = @PayUserFee, `PayAmount` = @PayAmount, `CashAmount` = @CashAmount, `CashOwnFee` = @CashOwnFee, `CashUserFee` = @CashUserFee WHERE `DayID` = @DayID_Original AND `OperatorID` = @OperatorID_Original AND `BankID` = @BankID_Original AND `PaytypeID` = @PaytypeID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", item.BankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", item.PaytypeID, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PayUsers", item.PayUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@CashUsers", item.CashUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@PayOwnFee", item.PayOwnFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@PayUserFee", item.PayUserFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@PayAmount", item.PayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@CashAmount", item.CashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@CashOwnFee", item.CashOwnFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@CashUserFee", item.CashUserFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@DayID_Original", item.HasOriginal ? item.OriginalDayID : item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID_Original", item.HasOriginal ? item.OriginalBankID : item.BankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID_Original", item.HasOriginal ? item.OriginalPaytypeID : item.PaytypeID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sr_oper_bank_paytype_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sr_oper_bank_paytype_dayEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, string set_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", ConcatValues(values_, dayID, operatorID, bankID, paytypeID));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", ConcatValues(values_, dayID, operatorID, bankID, paytypeID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", tm_, ConcatValues(values_, dayID, operatorID, bankID, paytypeID));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", tm_, ConcatValues(values_, dayID, operatorID, bankID, paytypeID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
	        };
			return Put(set_, "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutBankID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
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
		#region PutPaytypeID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPaytypeID(int paytypeID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PaytypeID` = @PaytypeID";
			var parameter_ = Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPaytypeIDAsync(int paytypeID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PaytypeID` = @PaytypeID";
			var parameter_ = Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPaytypeID
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(dayID, operatorID, bankID, paytypeID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(dayID, operatorID, bankID, paytypeID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryID(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryID
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(dayID, operatorID, bankID, paytypeID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(dayID, operatorID, bankID, paytypeID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyID
		#region PutPayUsers
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "payUsers">充值用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayUsersByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, int payUsers, TransactionManager tm_ = null)
		{
			RepairPutPayUsersByPKData(dayID, operatorID, bankID, paytypeID, payUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayUsersByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, int payUsers, TransactionManager tm_ = null)
		{
			RepairPutPayUsersByPKData(dayID, operatorID, bankID, paytypeID, payUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayUsersByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, int payUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayUsers` = @PayUsers  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayUsers", payUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payUsers">充值用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayUsers(int payUsers, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayUsers` = @PayUsers";
			var parameter_ = Database.CreateInParameter("@PayUsers", payUsers, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayUsersAsync(int payUsers, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayUsers` = @PayUsers";
			var parameter_ = Database.CreateInParameter("@PayUsers", payUsers, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayUsers
		#region PutCashUsers
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashUsersByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, int cashUsers, TransactionManager tm_ = null)
		{
			RepairPutCashUsersByPKData(dayID, operatorID, bankID, paytypeID, cashUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashUsersByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, int cashUsers, TransactionManager tm_ = null)
		{
			RepairPutCashUsersByPKData(dayID, operatorID, bankID, paytypeID, cashUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashUsersByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, int cashUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashUsers` = @CashUsers  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashUsers", cashUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashUsers(int cashUsers, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashUsers` = @CashUsers";
			var parameter_ = Database.CreateInParameter("@CashUsers", cashUsers, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashUsersAsync(int cashUsers, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashUsers` = @CashUsers";
			var parameter_ = Database.CreateInParameter("@CashUsers", cashUsers, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashUsers
		#region PutPayOwnFee
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayOwnFeeByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, decimal payOwnFee, TransactionManager tm_ = null)
		{
			RepairPutPayOwnFeeByPKData(dayID, operatorID, bankID, paytypeID, payOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayOwnFeeByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, decimal payOwnFee, TransactionManager tm_ = null)
		{
			RepairPutPayOwnFeeByPKData(dayID, operatorID, bankID, paytypeID, payOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayOwnFeeByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, decimal payOwnFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayOwnFee` = @PayOwnFee  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayOwnFee(decimal payOwnFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayOwnFee` = @PayOwnFee";
			var parameter_ = Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayOwnFeeAsync(decimal payOwnFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayOwnFee` = @PayOwnFee";
			var parameter_ = Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayOwnFee
		#region PutPayUserFee
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayUserFeeByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, decimal payUserFee, TransactionManager tm_ = null)
		{
			RepairPutPayUserFeeByPKData(dayID, operatorID, bankID, paytypeID, payUserFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayUserFeeByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, decimal payUserFee, TransactionManager tm_ = null)
		{
			RepairPutPayUserFeeByPKData(dayID, operatorID, bankID, paytypeID, payUserFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayUserFeeByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, decimal payUserFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayUserFee` = @PayUserFee  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayUserFee(decimal payUserFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayUserFee` = @PayUserFee";
			var parameter_ = Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayUserFeeAsync(decimal payUserFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayUserFee` = @PayUserFee";
			var parameter_ = Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayUserFee
		#region PutPayAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAmountByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, long payAmount, TransactionManager tm_ = null)
		{
			RepairPutPayAmountByPKData(dayID, operatorID, bankID, paytypeID, payAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayAmountByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, long payAmount, TransactionManager tm_ = null)
		{
			RepairPutPayAmountByPKData(dayID, operatorID, bankID, paytypeID, payAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayAmountByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, long payAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayAmount` = @PayAmount  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayAmount(long payAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayAmount` = @PayAmount";
			var parameter_ = Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayAmountAsync(long payAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayAmount` = @PayAmount";
			var parameter_ = Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayAmount
		#region PutCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAmountByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, long cashAmount, TransactionManager tm_ = null)
		{
			RepairPutCashAmountByPKData(dayID, operatorID, bankID, paytypeID, cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashAmountByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, long cashAmount, TransactionManager tm_ = null)
		{
			RepairPutCashAmountByPKData(dayID, operatorID, bankID, paytypeID, cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashAmountByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, long cashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashAmount` = @CashAmount  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAmount(long cashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashAmount` = @CashAmount";
			var parameter_ = Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashAmountAsync(long cashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashAmount` = @CashAmount";
			var parameter_ = Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashAmount
		#region PutCashOwnFee
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashOwnFeeByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, decimal cashOwnFee, TransactionManager tm_ = null)
		{
			RepairPutCashOwnFeeByPKData(dayID, operatorID, bankID, paytypeID, cashOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashOwnFeeByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, decimal cashOwnFee, TransactionManager tm_ = null)
		{
			RepairPutCashOwnFeeByPKData(dayID, operatorID, bankID, paytypeID, cashOwnFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashOwnFeeByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, decimal cashOwnFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashOwnFee` = @CashOwnFee  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashOwnFee", cashOwnFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashOwnFee(decimal cashOwnFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashOwnFee` = @CashOwnFee";
			var parameter_ = Database.CreateInParameter("@CashOwnFee", cashOwnFee, MySqlDbType.NewDecimal);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashOwnFeeAsync(decimal cashOwnFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashOwnFee` = @CashOwnFee";
			var parameter_ = Database.CreateInParameter("@CashOwnFee", cashOwnFee, MySqlDbType.NewDecimal);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashOwnFee
		#region PutCashUserFee
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashUserFeeByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, decimal cashUserFee, TransactionManager tm_ = null)
		{
			RepairPutCashUserFeeByPKData(dayID, operatorID, bankID, paytypeID, cashUserFee, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashUserFeeByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, decimal cashUserFee, TransactionManager tm_ = null)
		{
			RepairPutCashUserFeeByPKData(dayID, operatorID, bankID, paytypeID, cashUserFee, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashUserFeeByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, decimal cashUserFee, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashUserFee` = @CashUserFee  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashUserFee(decimal cashUserFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashUserFee` = @CashUserFee";
			var parameter_ = Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashUserFeeAsync(decimal cashUserFee, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashUserFee` = @CashUserFee";
			var parameter_ = Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashUserFee
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayID, operatorID, bankID, paytypeID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayID, operatorID, bankID, paytypeID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sr_oper_bank_paytype_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.OperatorID, item.BankID, item.PaytypeID) == null)
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
		public async Task<bool> SetAsync(Sr_oper_bank_paytype_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.OperatorID, item.BankID, item.PaytypeID) == null)
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
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sr_oper_bank_paytype_dayEO GetByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, operatorID, bankID, paytypeID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<Sr_oper_bank_paytype_dayEO> GetByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, operatorID, bankID, paytypeID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime dayID, string operatorID, string bankID, int paytypeID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 DayID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIDByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (DateTime)GetScalar("`DayID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<DateTime> GetDayIDByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (DateTime)await GetScalarAsync("`DayID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`OperatorID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BankID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBankIDByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`BankID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<string> GetBankIDByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`BankID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PaytypeID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPaytypeIDByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`PaytypeID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<int> GetPaytypeIDByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`PaytypeID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`CountryID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`CountryID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`CurrencyID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayUsers（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPayUsersByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`PayUsers`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<int> GetPayUsersByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`PayUsers`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashUsers（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCashUsersByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`CashUsers`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<int> GetCashUsersByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`CashUsers`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayOwnFee（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public decimal GetPayOwnFeeByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (decimal)GetScalar("`PayOwnFee`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<decimal> GetPayOwnFeeByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (decimal)await GetScalarAsync("`PayOwnFee`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayUserFee（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public decimal GetPayUserFeeByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (decimal)GetScalar("`PayUserFee`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<decimal> GetPayUserFeeByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (decimal)await GetScalarAsync("`PayUserFee`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPayAmountByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (long)GetScalar("`PayAmount`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<long> GetPayAmountByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`PayAmount`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCashAmountByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (long)GetScalar("`CashAmount`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<long> GetCashAmountByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`CashAmount`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashOwnFee（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public decimal GetCashOwnFeeByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (decimal)GetScalar("`CashOwnFee`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<decimal> GetCashOwnFeeByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (decimal)await GetScalarAsync("`CashOwnFee`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashUserFee（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public decimal GetCashUserFeeByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (decimal)GetScalar("`CashUserFee`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<decimal> GetCashUserFeeByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (decimal)await GetScalarAsync("`CashUserFee`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bankID">银行编码</param>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (DateTime)GetScalar("`RecDate`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(DateTime dayID, string operatorID, string bankID, int paytypeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DayID` = @DayID AND `OperatorID` = @OperatorID AND `BankID` = @BankID AND `PaytypeID` = @PaytypeID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByDayID(DateTime dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByDayIDAsync(DateTime dayID)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByDayID(DateTime dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByDayIDAsync(DateTime dayID, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByDayID(DateTime dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByDayIDAsync(DateTime dayID, int top_)
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
		public List<Sr_oper_bank_paytype_dayEO> GetByDayID(DateTime dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByDayID(DateTime dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_)
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
		public List<Sr_oper_bank_paytype_dayEO> GetByDayID(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_, TransactionManager tm_)
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
		public List<Sr_oper_bank_paytype_dayEO> GetByDayID(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sr_oper_bank_paytype_dayEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sr_oper_bank_paytype_dayEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sr_oper_bank_paytype_dayEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByBankID
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByBankID(string bankID)
		{
			return GetByBankID(bankID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByBankIDAsync(string bankID)
		{
			return await GetByBankIDAsync(bankID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByBankID(string bankID, TransactionManager tm_)
		{
			return GetByBankID(bankID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByBankIDAsync(string bankID, TransactionManager tm_)
		{
			return await GetByBankIDAsync(bankID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByBankID(string bankID, int top_)
		{
			return GetByBankID(bankID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByBankIDAsync(string bankID, int top_)
		{
			return await GetByBankIDAsync(bankID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByBankID(string bankID, int top_, TransactionManager tm_)
		{
			return GetByBankID(bankID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByBankIDAsync(string bankID, int top_, TransactionManager tm_)
		{
			return await GetByBankIDAsync(bankID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByBankID(string bankID, string sort_)
		{
			return GetByBankID(bankID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByBankIDAsync(string bankID, string sort_)
		{
			return await GetByBankIDAsync(bankID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByBankID(string bankID, string sort_, TransactionManager tm_)
		{
			return GetByBankID(bankID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByBankIDAsync(string bankID, string sort_, TransactionManager tm_)
		{
			return await GetByBankIDAsync(bankID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BankID（字段） 查询
		/// </summary>
		/// /// <param name = "bankID">银行编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByBankID(string bankID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BankID` = @BankID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByBankIDAsync(string bankID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BankID` = @BankID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BankID", bankID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByBankID
		#region GetByPaytypeID
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPaytypeID(int paytypeID)
		{
			return GetByPaytypeID(paytypeID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPaytypeIDAsync(int paytypeID)
		{
			return await GetByPaytypeIDAsync(paytypeID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPaytypeID(int paytypeID, TransactionManager tm_)
		{
			return GetByPaytypeID(paytypeID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPaytypeIDAsync(int paytypeID, TransactionManager tm_)
		{
			return await GetByPaytypeIDAsync(paytypeID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPaytypeID(int paytypeID, int top_)
		{
			return GetByPaytypeID(paytypeID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPaytypeIDAsync(int paytypeID, int top_)
		{
			return await GetByPaytypeIDAsync(paytypeID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPaytypeID(int paytypeID, int top_, TransactionManager tm_)
		{
			return GetByPaytypeID(paytypeID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPaytypeIDAsync(int paytypeID, int top_, TransactionManager tm_)
		{
			return await GetByPaytypeIDAsync(paytypeID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPaytypeID(int paytypeID, string sort_)
		{
			return GetByPaytypeID(paytypeID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPaytypeIDAsync(int paytypeID, string sort_)
		{
			return await GetByPaytypeIDAsync(paytypeID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPaytypeID(int paytypeID, string sort_, TransactionManager tm_)
		{
			return GetByPaytypeID(paytypeID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPaytypeIDAsync(int paytypeID, string sort_, TransactionManager tm_)
		{
			return await GetByPaytypeIDAsync(paytypeID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PaytypeID（字段） 查询
		/// </summary>
		/// /// <param name = "paytypeID">支付方式0-综合1-visa2-spei</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPaytypeID(int paytypeID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PaytypeID` = @PaytypeID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPaytypeIDAsync(int paytypeID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PaytypeID` = @PaytypeID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PaytypeID", paytypeID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByPaytypeID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCountryIDAsync(string countryID, int top_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCountryIDAsync(string countryID, string sort_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByPayUsers
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUsers(int payUsers)
		{
			return GetByPayUsers(payUsers, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUsersAsync(int payUsers)
		{
			return await GetByPayUsersAsync(payUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUsers(int payUsers, TransactionManager tm_)
		{
			return GetByPayUsers(payUsers, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUsersAsync(int payUsers, TransactionManager tm_)
		{
			return await GetByPayUsersAsync(payUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUsers(int payUsers, int top_)
		{
			return GetByPayUsers(payUsers, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUsersAsync(int payUsers, int top_)
		{
			return await GetByPayUsersAsync(payUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUsers(int payUsers, int top_, TransactionManager tm_)
		{
			return GetByPayUsers(payUsers, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUsersAsync(int payUsers, int top_, TransactionManager tm_)
		{
			return await GetByPayUsersAsync(payUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUsers(int payUsers, string sort_)
		{
			return GetByPayUsers(payUsers, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUsersAsync(int payUsers, string sort_)
		{
			return await GetByPayUsersAsync(payUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUsers(int payUsers, string sort_, TransactionManager tm_)
		{
			return GetByPayUsers(payUsers, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUsersAsync(int payUsers, string sort_, TransactionManager tm_)
		{
			return await GetByPayUsersAsync(payUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayUsers（字段） 查询
		/// </summary>
		/// /// <param name = "payUsers">充值用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUsers(int payUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayUsers` = @PayUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayUsers", payUsers, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUsersAsync(int payUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayUsers` = @PayUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayUsers", payUsers, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByPayUsers
		#region GetByCashUsers
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUsers(int cashUsers)
		{
			return GetByCashUsers(cashUsers, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUsersAsync(int cashUsers)
		{
			return await GetByCashUsersAsync(cashUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUsers(int cashUsers, TransactionManager tm_)
		{
			return GetByCashUsers(cashUsers, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUsersAsync(int cashUsers, TransactionManager tm_)
		{
			return await GetByCashUsersAsync(cashUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUsers(int cashUsers, int top_)
		{
			return GetByCashUsers(cashUsers, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUsersAsync(int cashUsers, int top_)
		{
			return await GetByCashUsersAsync(cashUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUsers(int cashUsers, int top_, TransactionManager tm_)
		{
			return GetByCashUsers(cashUsers, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUsersAsync(int cashUsers, int top_, TransactionManager tm_)
		{
			return await GetByCashUsersAsync(cashUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUsers(int cashUsers, string sort_)
		{
			return GetByCashUsers(cashUsers, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUsersAsync(int cashUsers, string sort_)
		{
			return await GetByCashUsersAsync(cashUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUsers(int cashUsers, string sort_, TransactionManager tm_)
		{
			return GetByCashUsers(cashUsers, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUsersAsync(int cashUsers, string sort_, TransactionManager tm_)
		{
			return await GetByCashUsersAsync(cashUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashUsers（字段） 查询
		/// </summary>
		/// /// <param name = "cashUsers">提现用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUsers(int cashUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashUsers` = @CashUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashUsers", cashUsers, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUsersAsync(int cashUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashUsers` = @CashUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashUsers", cashUsers, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByCashUsers
		#region GetByPayOwnFee
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayOwnFee(decimal payOwnFee)
		{
			return GetByPayOwnFee(payOwnFee, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayOwnFee(decimal payOwnFee, TransactionManager tm_)
		{
			return GetByPayOwnFee(payOwnFee, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee, TransactionManager tm_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayOwnFee(decimal payOwnFee, int top_)
		{
			return GetByPayOwnFee(payOwnFee, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee, int top_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayOwnFee(decimal payOwnFee, int top_, TransactionManager tm_)
		{
			return GetByPayOwnFee(payOwnFee, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee, int top_, TransactionManager tm_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayOwnFee(decimal payOwnFee, string sort_)
		{
			return GetByPayOwnFee(payOwnFee, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee, string sort_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayOwnFee(decimal payOwnFee, string sort_, TransactionManager tm_)
		{
			return GetByPayOwnFee(payOwnFee, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee, string sort_, TransactionManager tm_)
		{
			return await GetByPayOwnFeeAsync(payOwnFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "payOwnFee">充值我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayOwnFee(decimal payOwnFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayOwnFee` = @PayOwnFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayOwnFeeAsync(decimal payOwnFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayOwnFee` = @PayOwnFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayOwnFee", payOwnFee, MySqlDbType.NewDecimal));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByPayOwnFee
		#region GetByPayUserFee
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUserFee(decimal payUserFee)
		{
			return GetByPayUserFee(payUserFee, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUserFeeAsync(decimal payUserFee)
		{
			return await GetByPayUserFeeAsync(payUserFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUserFee(decimal payUserFee, TransactionManager tm_)
		{
			return GetByPayUserFee(payUserFee, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUserFeeAsync(decimal payUserFee, TransactionManager tm_)
		{
			return await GetByPayUserFeeAsync(payUserFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUserFee(decimal payUserFee, int top_)
		{
			return GetByPayUserFee(payUserFee, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUserFeeAsync(decimal payUserFee, int top_)
		{
			return await GetByPayUserFeeAsync(payUserFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUserFee(decimal payUserFee, int top_, TransactionManager tm_)
		{
			return GetByPayUserFee(payUserFee, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUserFeeAsync(decimal payUserFee, int top_, TransactionManager tm_)
		{
			return await GetByPayUserFeeAsync(payUserFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUserFee(decimal payUserFee, string sort_)
		{
			return GetByPayUserFee(payUserFee, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUserFeeAsync(decimal payUserFee, string sort_)
		{
			return await GetByPayUserFeeAsync(payUserFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUserFee(decimal payUserFee, string sort_, TransactionManager tm_)
		{
			return GetByPayUserFee(payUserFee, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUserFeeAsync(decimal payUserFee, string sort_, TransactionManager tm_)
		{
			return await GetByPayUserFeeAsync(payUserFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "payUserFee">充值用户手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayUserFee(decimal payUserFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayUserFee` = @PayUserFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayUserFeeAsync(decimal payUserFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayUserFee` = @PayUserFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayUserFee", payUserFee, MySqlDbType.NewDecimal));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByPayUserFee
		#region GetByPayAmount
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayAmount(long payAmount)
		{
			return GetByPayAmount(payAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayAmountAsync(long payAmount)
		{
			return await GetByPayAmountAsync(payAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayAmount(long payAmount, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayAmountAsync(long payAmount, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayAmount(long payAmount, int top_)
		{
			return GetByPayAmount(payAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayAmountAsync(long payAmount, int top_)
		{
			return await GetByPayAmountAsync(payAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayAmount(long payAmount, int top_, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayAmountAsync(long payAmount, int top_, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayAmount(long payAmount, string sort_)
		{
			return GetByPayAmount(payAmount, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayAmountAsync(long payAmount, string sort_)
		{
			return await GetByPayAmountAsync(payAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayAmount(long payAmount, string sort_, TransactionManager tm_)
		{
			return GetByPayAmount(payAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayAmountAsync(long payAmount, string sort_, TransactionManager tm_)
		{
			return await GetByPayAmountAsync(payAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "payAmount">充值数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByPayAmount(long payAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmount` = @PayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByPayAmountAsync(long payAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayAmount` = @PayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayAmount", payAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByPayAmount
		#region GetByCashAmount
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashAmount(long cashAmount)
		{
			return GetByCashAmount(cashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashAmountAsync(long cashAmount)
		{
			return await GetByCashAmountAsync(cashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashAmount(long cashAmount, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashAmountAsync(long cashAmount, TransactionManager tm_)
		{
			return await GetByCashAmountAsync(cashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashAmount(long cashAmount, int top_)
		{
			return GetByCashAmount(cashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashAmountAsync(long cashAmount, int top_)
		{
			return await GetByCashAmountAsync(cashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashAmount(long cashAmount, int top_, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashAmountAsync(long cashAmount, int top_, TransactionManager tm_)
		{
			return await GetByCashAmountAsync(cashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashAmount(long cashAmount, string sort_)
		{
			return GetByCashAmount(cashAmount, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashAmountAsync(long cashAmount, string sort_)
		{
			return await GetByCashAmountAsync(cashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashAmount(long cashAmount, string sort_, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashAmountAsync(long cashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByCashAmountAsync(cashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashAmount(long cashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAmount` = @CashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashAmountAsync(long cashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAmount` = @CashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByCashAmount
		#region GetByCashOwnFee
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashOwnFee(decimal cashOwnFee)
		{
			return GetByCashOwnFee(cashOwnFee, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashOwnFeeAsync(decimal cashOwnFee)
		{
			return await GetByCashOwnFeeAsync(cashOwnFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashOwnFee(decimal cashOwnFee, TransactionManager tm_)
		{
			return GetByCashOwnFee(cashOwnFee, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashOwnFeeAsync(decimal cashOwnFee, TransactionManager tm_)
		{
			return await GetByCashOwnFeeAsync(cashOwnFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashOwnFee(decimal cashOwnFee, int top_)
		{
			return GetByCashOwnFee(cashOwnFee, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashOwnFeeAsync(decimal cashOwnFee, int top_)
		{
			return await GetByCashOwnFeeAsync(cashOwnFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashOwnFee(decimal cashOwnFee, int top_, TransactionManager tm_)
		{
			return GetByCashOwnFee(cashOwnFee, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashOwnFeeAsync(decimal cashOwnFee, int top_, TransactionManager tm_)
		{
			return await GetByCashOwnFeeAsync(cashOwnFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashOwnFee(decimal cashOwnFee, string sort_)
		{
			return GetByCashOwnFee(cashOwnFee, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashOwnFeeAsync(decimal cashOwnFee, string sort_)
		{
			return await GetByCashOwnFeeAsync(cashOwnFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashOwnFee(decimal cashOwnFee, string sort_, TransactionManager tm_)
		{
			return GetByCashOwnFee(cashOwnFee, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashOwnFeeAsync(decimal cashOwnFee, string sort_, TransactionManager tm_)
		{
			return await GetByCashOwnFeeAsync(cashOwnFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashOwnFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashOwnFee">提现我方手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashOwnFee(decimal cashOwnFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashOwnFee` = @CashOwnFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashOwnFee", cashOwnFee, MySqlDbType.NewDecimal));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashOwnFeeAsync(decimal cashOwnFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashOwnFee` = @CashOwnFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashOwnFee", cashOwnFee, MySqlDbType.NewDecimal));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByCashOwnFee
		#region GetByCashUserFee
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUserFee(decimal cashUserFee)
		{
			return GetByCashUserFee(cashUserFee, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee)
		{
			return await GetByCashUserFeeAsync(cashUserFee, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUserFee(decimal cashUserFee, TransactionManager tm_)
		{
			return GetByCashUserFee(cashUserFee, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee, TransactionManager tm_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUserFee(decimal cashUserFee, int top_)
		{
			return GetByCashUserFee(cashUserFee, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee, int top_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUserFee(decimal cashUserFee, int top_, TransactionManager tm_)
		{
			return GetByCashUserFee(cashUserFee, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee, int top_, TransactionManager tm_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUserFee(decimal cashUserFee, string sort_)
		{
			return GetByCashUserFee(cashUserFee, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee, string sort_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUserFee(decimal cashUserFee, string sort_, TransactionManager tm_)
		{
			return GetByCashUserFee(cashUserFee, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee, string sort_, TransactionManager tm_)
		{
			return await GetByCashUserFeeAsync(cashUserFee, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashUserFee（字段） 查询
		/// </summary>
		/// /// <param name = "cashUserFee">提现用户手续费</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByCashUserFee(decimal cashUserFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashUserFee` = @CashUserFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByCashUserFeeAsync(decimal cashUserFee, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashUserFee` = @CashUserFee", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashUserFee", cashUserFee, MySqlDbType.NewDecimal));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByCashUserFee
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_bank_paytype_dayEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_bank_paytype_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_bank_paytype_dayEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
