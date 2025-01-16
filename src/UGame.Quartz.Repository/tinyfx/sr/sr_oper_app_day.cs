/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-10-25 10: 38:52
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
	/// 按照app统计下注金额
	/// 【表 sr_oper_app_day 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sr_oper_app_dayEO : IRowMapper<Sr_oper_app_dayEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sr_oper_app_dayEO()
		{
			this.BetUsers = 0;
			this.NewBetUsers = 0;
			this.NewUserBetAmount = 0;
			this.NewUserWinAmount = 0;
			this.NewUserBetBonus = 0;
			this.NewUserWinBonus = 0;
			this.BetCount = 0;
			this.BetAmount = 0;
			this.BetBonus = 0;
			this.WinCount = 0;
			this.WinAmount = 0;
			this.WinBonus = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private DateTime _originalDayId;
		/// <summary>
		/// 【数据库中的原始主键 DayId 值的副本，用于主键值更新】
		/// </summary>
		public DateTime OriginalDayId
		{
			get { return _originalDayId; }
			set { HasOriginal = true; _originalDayId = value; }
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
		
		private string _originalAppID;
		/// <summary>
		/// 【数据库中的原始主键 AppID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalAppID
		{
			get { return _originalAppID; }
			set { HasOriginal = true; _originalAppID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DayId", DayId },  { "OperatorID", OperatorID },  { "AppID", AppID }, };
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
		public DateTime DayId { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 应用编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string AppID { get; set; }
		/// <summary>
		/// 应用提供商
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string ProviderID { get; set; }
		/// <summary>
		/// 货币类型（仅现金，其它另行统计）
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 5)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 6)]
		public string CountryID { get; set; }
		/// <summary>
		/// 下注用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int BetUsers { get; set; }
		/// <summary>
		/// 新下注用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int NewBetUsers { get; set; }
		/// <summary>
		/// 新用户下注额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long NewUserBetAmount { get; set; }
		/// <summary>
		/// 新用户返奖额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long NewUserWinAmount { get; set; }
		/// <summary>
		/// 新用户下注的bonus
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 11)]
		public long NewUserBetBonus { get; set; }
		/// <summary>
		/// 新用户返奖bonus
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 12)]
		public long NewUserWinBonus { get; set; }
		/// <summary>
		/// 下注次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 13)]
		public int BetCount { get; set; }
		/// <summary>
		/// 当天用户下注额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 14)]
		public long BetAmount { get; set; }
		/// <summary>
		/// 当天用户bonus下注
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 15)]
		public long BetBonus { get; set; }
		/// <summary>
		/// 返奖次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 16)]
		public int WinCount { get; set; }
		/// <summary>
		/// 当天用户返奖额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 17)]
		public long WinAmount { get; set; }
		/// <summary>
		/// 当天用户bonus返奖
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 18)]
		public long WinBonus { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 19)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sr_oper_app_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sr_oper_app_dayEO MapDataReader(IDataReader reader)
		{
		    Sr_oper_app_dayEO ret = new Sr_oper_app_dayEO();
			ret.DayId = reader.ToDateTime("DayId");
			ret.OriginalDayId = ret.DayId;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.AppID = reader.ToString("AppID");
			ret.OriginalAppID = ret.AppID;
			ret.ProviderID = reader.ToString("ProviderID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.CountryID = reader.ToString("CountryID");
			ret.BetUsers = reader.ToInt32("BetUsers");
			ret.NewBetUsers = reader.ToInt32("NewBetUsers");
			ret.NewUserBetAmount = reader.ToInt64("NewUserBetAmount");
			ret.NewUserWinAmount = reader.ToInt64("NewUserWinAmount");
			ret.NewUserBetBonus = reader.ToInt64("NewUserBetBonus");
			ret.NewUserWinBonus = reader.ToInt64("NewUserWinBonus");
			ret.BetCount = reader.ToInt32("BetCount");
			ret.BetAmount = reader.ToInt64("BetAmount");
			ret.BetBonus = reader.ToInt64("BetBonus");
			ret.WinCount = reader.ToInt32("WinCount");
			ret.WinAmount = reader.ToInt64("WinAmount");
			ret.WinBonus = reader.ToInt64("WinBonus");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 按照app统计下注金额
	/// 【表 sr_oper_app_day 的操作类】
	/// </summary>
	[Obsolete]
	public class Sr_oper_app_dayMO : MySqlTableMO<Sr_oper_app_dayEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sr_oper_app_day`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sr_oper_app_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sr_oper_app_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sr_oper_app_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sr_oper_app_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sr_oper_app_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sr_oper_app_dayEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DayId`, `OperatorID`, `AppID`, `ProviderID`, `CurrencyID`, `CountryID`, `BetUsers`, `NewBetUsers`, `NewUserBetAmount`, `NewUserWinAmount`, `NewUserBetBonus`, `NewUserWinBonus`, `BetCount`, `BetAmount`, `BetBonus`, `WinCount`, `WinAmount`, `WinBonus`, `RecDate`) VALUE (@DayId, @OperatorID, @AppID, @ProviderID, @CurrencyID, @CountryID, @BetUsers, @NewBetUsers, @NewUserBetAmount, @NewUserWinAmount, @NewUserBetBonus, @NewUserWinBonus, @BetCount, @BetAmount, @BetBonus, @WinCount, @WinAmount, @WinBonus, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", item.ProviderID != null ? item.ProviderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetUsers", item.BetUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@NewBetUsers", item.NewBetUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@NewUserBetAmount", item.NewUserBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@NewUserWinAmount", item.NewUserWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@NewUserBetBonus", item.NewUserBetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@NewUserWinBonus", item.NewUserWinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@BetCount", item.BetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonus", item.BetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@WinCount", item.WinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonus", item.WinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sr_oper_app_dayEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sr_oper_app_dayEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sr_oper_app_dayEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DayId`, `OperatorID`, `AppID`, `ProviderID`, `CurrencyID`, `CountryID`, `BetUsers`, `NewBetUsers`, `NewUserBetAmount`, `NewUserWinAmount`, `NewUserBetBonus`, `NewUserWinBonus`, `BetCount`, `BetAmount`, `BetBonus`, `WinCount`, `WinAmount`, `WinBonus`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DayId.ToString("yyyy-MM-dd HH:mm:ss")}','{item.OperatorID}','{item.AppID}','{item.ProviderID}','{item.CurrencyID}','{item.CountryID}',{item.BetUsers},{item.NewBetUsers},{item.NewUserBetAmount},{item.NewUserWinAmount},{item.NewUserBetBonus},{item.NewUserWinBonus},{item.BetCount},{item.BetAmount},{item.BetBonus},{item.WinCount},{item.WinAmount},{item.WinBonus},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayId, operatorID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayId, operatorID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime dayId, string operatorID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sr_oper_app_dayEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DayId, item.OperatorID, item.AppID, tm_);
		}
		public async Task<int> RemoveAsync(Sr_oper_app_dayEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DayId, item.OperatorID, item.AppID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByDayId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDayId(DateTime dayId, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIdData(dayId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDayIdAsync(DateTime dayId, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIdData(dayId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDayIdData(DateTime dayId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayId` = @DayId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
		}
		#endregion // RemoveByDayId
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
		#region RemoveByAppID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppID(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppIDData(string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAppID
		#region RemoveByProviderID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProviderID(string providerID, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderIDData(providerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProviderIDAsync(string providerID, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderIDData(providerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProviderIDData(string providerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByProviderID
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
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
		#region RemoveByBetUsers
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetUsers(int betUsers, TransactionManager tm_ = null)
		{
			RepairRemoveByBetUsersData(betUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetUsersAsync(int betUsers, TransactionManager tm_ = null)
		{
			RepairRemoveByBetUsersData(betUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetUsersData(int betUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetUsers` = @BetUsers";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int32));
		}
		#endregion // RemoveByBetUsers
		#region RemoveByNewBetUsers
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNewBetUsers(int newBetUsers, TransactionManager tm_ = null)
		{
			RepairRemoveByNewBetUsersData(newBetUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNewBetUsersAsync(int newBetUsers, TransactionManager tm_ = null)
		{
			RepairRemoveByNewBetUsersData(newBetUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNewBetUsersData(int newBetUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NewBetUsers` = @NewBetUsers";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewBetUsers", newBetUsers, MySqlDbType.Int32));
		}
		#endregion // RemoveByNewBetUsers
		#region RemoveByNewUserBetAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNewUserBetAmount(long newUserBetAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByNewUserBetAmountData(newUserBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNewUserBetAmountAsync(long newUserBetAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByNewUserBetAmountData(newUserBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNewUserBetAmountData(long newUserBetAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NewUserBetAmount` = @NewUserBetAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserBetAmount", newUserBetAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByNewUserBetAmount
		#region RemoveByNewUserWinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNewUserWinAmount(long newUserWinAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByNewUserWinAmountData(newUserWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNewUserWinAmountAsync(long newUserWinAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByNewUserWinAmountData(newUserWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNewUserWinAmountData(long newUserWinAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NewUserWinAmount` = @NewUserWinAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserWinAmount", newUserWinAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByNewUserWinAmount
		#region RemoveByNewUserBetBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNewUserBetBonus(long newUserBetBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByNewUserBetBonusData(newUserBetBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNewUserBetBonusAsync(long newUserBetBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByNewUserBetBonusData(newUserBetBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNewUserBetBonusData(long newUserBetBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NewUserBetBonus` = @NewUserBetBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserBetBonus", newUserBetBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByNewUserBetBonus
		#region RemoveByNewUserWinBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNewUserWinBonus(long newUserWinBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByNewUserWinBonusData(newUserWinBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNewUserWinBonusAsync(long newUserWinBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByNewUserWinBonusData(newUserWinBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNewUserWinBonusData(long newUserWinBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NewUserWinBonus` = @NewUserWinBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserWinBonus", newUserWinBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByNewUserWinBonus
		#region RemoveByBetCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetCount(int betCount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetCountData(betCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetCountAsync(int betCount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetCountData(betCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetCountData(int betCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetCount` = @BetCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByBetCount
		#region RemoveByBetAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetAmount(long betAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetAmountData(betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetAmountAsync(long betAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetAmountData(betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetAmountData(long betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetAmount` = @BetAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetAmount
		#region RemoveByBetBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetBonus(long betBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBonusData(betBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetBonusAsync(long betBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBonusData(betBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetBonusData(long betBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetBonus` = @BetBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetBonus
		#region RemoveByWinCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinCount(int winCount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinCountData(winCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinCountAsync(int winCount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinCountData(winCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinCountData(int winCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinCount` = @WinCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByWinCount
		#region RemoveByWinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinAmount(long winAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinAmountData(winAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinAmountAsync(long winAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinAmountData(winAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinAmountData(long winAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinAmount` = @WinAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinAmount
		#region RemoveByWinBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinBonus(long winBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByWinBonusData(winBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinBonusAsync(long winBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByWinBonusData(winBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinBonusData(long winBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinBonus` = @WinBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinBonus
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
		public int Put(Sr_oper_app_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sr_oper_app_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sr_oper_app_dayEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayId` = @DayId, `OperatorID` = @OperatorID, `AppID` = @AppID, `ProviderID` = @ProviderID, `CurrencyID` = @CurrencyID, `CountryID` = @CountryID, `BetUsers` = @BetUsers, `NewBetUsers` = @NewBetUsers, `NewUserBetAmount` = @NewUserBetAmount, `NewUserWinAmount` = @NewUserWinAmount, `NewUserBetBonus` = @NewUserBetBonus, `NewUserWinBonus` = @NewUserWinBonus, `BetCount` = @BetCount, `BetAmount` = @BetAmount, `BetBonus` = @BetBonus, `WinCount` = @WinCount, `WinAmount` = @WinAmount, `WinBonus` = @WinBonus WHERE `DayId` = @DayId_Original AND `OperatorID` = @OperatorID_Original AND `AppID` = @AppID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", item.ProviderID != null ? item.ProviderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetUsers", item.BetUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@NewBetUsers", item.NewBetUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@NewUserBetAmount", item.NewUserBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@NewUserWinAmount", item.NewUserWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@NewUserBetBonus", item.NewUserBetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@NewUserWinBonus", item.NewUserWinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@BetCount", item.BetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonus", item.BetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@WinCount", item.WinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonus", item.WinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId_Original", item.HasOriginal ? item.OriginalDayId : item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID_Original", item.HasOriginal ? item.OriginalAppID : item.AppID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sr_oper_app_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sr_oper_app_dayEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayId, string operatorID, string appID, string set_, params object[] values_)
		{
			return Put(set_, "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", ConcatValues(values_, dayId, operatorID, appID));
		}
		public async Task<int> PutByPKAsync(DateTime dayId, string operatorID, string appID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", ConcatValues(values_, dayId, operatorID, appID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayId, string operatorID, string appID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", tm_, ConcatValues(values_, dayId, operatorID, appID));
		}
		public async Task<int> PutByPKAsync(DateTime dayId, string operatorID, string appID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", tm_, ConcatValues(values_, dayId, operatorID, appID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayId, string operatorID, string appID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime dayId, string operatorID, string appID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutDayId
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDayId(DateTime dayId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayId` = @DayId";
			var parameter_ = Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDayIdAsync(DateTime dayId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayId` = @DayId";
			var parameter_ = Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDayId
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
		#region PutAppID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppID(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppID
		#region PutProviderID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderIDByPK(DateTime dayId, string operatorID, string appID, string providerID, TransactionManager tm_ = null)
		{
			RepairPutProviderIDByPKData(dayId, operatorID, appID, providerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProviderIDByPKAsync(DateTime dayId, string operatorID, string appID, string providerID, TransactionManager tm_ = null)
		{
			RepairPutProviderIDByPKData(dayId, operatorID, appID, providerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProviderIDByPKData(DateTime dayId, string operatorID, string appID, string providerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderID(string providerID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID";
			var parameter_ = Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProviderIDAsync(string providerID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID";
			var parameter_ = Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProviderID
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(DateTime dayId, string operatorID, string appID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(dayId, operatorID, appID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(DateTime dayId, string operatorID, string appID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(dayId, operatorID, appID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(DateTime dayId, string operatorID, string appID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
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
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(DateTime dayId, string operatorID, string appID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(dayId, operatorID, appID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(DateTime dayId, string operatorID, string appID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(dayId, operatorID, appID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(DateTime dayId, string operatorID, string appID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
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
		#region PutBetUsers
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetUsersByPK(DateTime dayId, string operatorID, string appID, int betUsers, TransactionManager tm_ = null)
		{
			RepairPutBetUsersByPKData(dayId, operatorID, appID, betUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetUsersByPKAsync(DateTime dayId, string operatorID, string appID, int betUsers, TransactionManager tm_ = null)
		{
			RepairPutBetUsersByPKData(dayId, operatorID, appID, betUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetUsersByPKData(DateTime dayId, string operatorID, string appID, int betUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetUsers` = @BetUsers  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetUsers(int betUsers, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetUsers` = @BetUsers";
			var parameter_ = Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetUsersAsync(int betUsers, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetUsers` = @BetUsers";
			var parameter_ = Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetUsers
		#region PutNewBetUsers
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewBetUsersByPK(DateTime dayId, string operatorID, string appID, int newBetUsers, TransactionManager tm_ = null)
		{
			RepairPutNewBetUsersByPKData(dayId, operatorID, appID, newBetUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNewBetUsersByPKAsync(DateTime dayId, string operatorID, string appID, int newBetUsers, TransactionManager tm_ = null)
		{
			RepairPutNewBetUsersByPKData(dayId, operatorID, appID, newBetUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNewBetUsersByPKData(DateTime dayId, string operatorID, string appID, int newBetUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NewBetUsers` = @NewBetUsers  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NewBetUsers", newBetUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewBetUsers(int newBetUsers, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewBetUsers` = @NewBetUsers";
			var parameter_ = Database.CreateInParameter("@NewBetUsers", newBetUsers, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNewBetUsersAsync(int newBetUsers, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewBetUsers` = @NewBetUsers";
			var parameter_ = Database.CreateInParameter("@NewBetUsers", newBetUsers, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNewBetUsers
		#region PutNewUserBetAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewUserBetAmountByPK(DateTime dayId, string operatorID, string appID, long newUserBetAmount, TransactionManager tm_ = null)
		{
			RepairPutNewUserBetAmountByPKData(dayId, operatorID, appID, newUserBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNewUserBetAmountByPKAsync(DateTime dayId, string operatorID, string appID, long newUserBetAmount, TransactionManager tm_ = null)
		{
			RepairPutNewUserBetAmountByPKData(dayId, operatorID, appID, newUserBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNewUserBetAmountByPKData(DateTime dayId, string operatorID, string appID, long newUserBetAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NewUserBetAmount` = @NewUserBetAmount  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NewUserBetAmount", newUserBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewUserBetAmount(long newUserBetAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewUserBetAmount` = @NewUserBetAmount";
			var parameter_ = Database.CreateInParameter("@NewUserBetAmount", newUserBetAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNewUserBetAmountAsync(long newUserBetAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewUserBetAmount` = @NewUserBetAmount";
			var parameter_ = Database.CreateInParameter("@NewUserBetAmount", newUserBetAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNewUserBetAmount
		#region PutNewUserWinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewUserWinAmountByPK(DateTime dayId, string operatorID, string appID, long newUserWinAmount, TransactionManager tm_ = null)
		{
			RepairPutNewUserWinAmountByPKData(dayId, operatorID, appID, newUserWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNewUserWinAmountByPKAsync(DateTime dayId, string operatorID, string appID, long newUserWinAmount, TransactionManager tm_ = null)
		{
			RepairPutNewUserWinAmountByPKData(dayId, operatorID, appID, newUserWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNewUserWinAmountByPKData(DateTime dayId, string operatorID, string appID, long newUserWinAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NewUserWinAmount` = @NewUserWinAmount  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NewUserWinAmount", newUserWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewUserWinAmount(long newUserWinAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewUserWinAmount` = @NewUserWinAmount";
			var parameter_ = Database.CreateInParameter("@NewUserWinAmount", newUserWinAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNewUserWinAmountAsync(long newUserWinAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewUserWinAmount` = @NewUserWinAmount";
			var parameter_ = Database.CreateInParameter("@NewUserWinAmount", newUserWinAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNewUserWinAmount
		#region PutNewUserBetBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewUserBetBonusByPK(DateTime dayId, string operatorID, string appID, long newUserBetBonus, TransactionManager tm_ = null)
		{
			RepairPutNewUserBetBonusByPKData(dayId, operatorID, appID, newUserBetBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNewUserBetBonusByPKAsync(DateTime dayId, string operatorID, string appID, long newUserBetBonus, TransactionManager tm_ = null)
		{
			RepairPutNewUserBetBonusByPKData(dayId, operatorID, appID, newUserBetBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNewUserBetBonusByPKData(DateTime dayId, string operatorID, string appID, long newUserBetBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NewUserBetBonus` = @NewUserBetBonus  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NewUserBetBonus", newUserBetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewUserBetBonus(long newUserBetBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewUserBetBonus` = @NewUserBetBonus";
			var parameter_ = Database.CreateInParameter("@NewUserBetBonus", newUserBetBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNewUserBetBonusAsync(long newUserBetBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewUserBetBonus` = @NewUserBetBonus";
			var parameter_ = Database.CreateInParameter("@NewUserBetBonus", newUserBetBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNewUserBetBonus
		#region PutNewUserWinBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewUserWinBonusByPK(DateTime dayId, string operatorID, string appID, long newUserWinBonus, TransactionManager tm_ = null)
		{
			RepairPutNewUserWinBonusByPKData(dayId, operatorID, appID, newUserWinBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNewUserWinBonusByPKAsync(DateTime dayId, string operatorID, string appID, long newUserWinBonus, TransactionManager tm_ = null)
		{
			RepairPutNewUserWinBonusByPKData(dayId, operatorID, appID, newUserWinBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNewUserWinBonusByPKData(DateTime dayId, string operatorID, string appID, long newUserWinBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NewUserWinBonus` = @NewUserWinBonus  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NewUserWinBonus", newUserWinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewUserWinBonus(long newUserWinBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewUserWinBonus` = @NewUserWinBonus";
			var parameter_ = Database.CreateInParameter("@NewUserWinBonus", newUserWinBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNewUserWinBonusAsync(long newUserWinBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewUserWinBonus` = @NewUserWinBonus";
			var parameter_ = Database.CreateInParameter("@NewUserWinBonus", newUserWinBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNewUserWinBonus
		#region PutBetCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetCountByPK(DateTime dayId, string operatorID, string appID, int betCount, TransactionManager tm_ = null)
		{
			RepairPutBetCountByPKData(dayId, operatorID, appID, betCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetCountByPKAsync(DateTime dayId, string operatorID, string appID, int betCount, TransactionManager tm_ = null)
		{
			RepairPutBetCountByPKData(dayId, operatorID, appID, betCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetCountByPKData(DateTime dayId, string operatorID, string appID, int betCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetCount` = @BetCount  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetCount(int betCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetCount` = @BetCount";
			var parameter_ = Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetCountAsync(int betCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetCount` = @BetCount";
			var parameter_ = Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetCount
		#region PutBetAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmountByPK(DateTime dayId, string operatorID, string appID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(dayId, operatorID, appID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetAmountByPKAsync(DateTime dayId, string operatorID, string appID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(dayId, operatorID, appID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetAmountByPKData(DateTime dayId, string operatorID, string appID, long betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmount(long betAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount";
			var parameter_ = Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetAmountAsync(long betAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount";
			var parameter_ = Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetAmount
		#region PutBetBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBonusByPK(DateTime dayId, string operatorID, string appID, long betBonus, TransactionManager tm_ = null)
		{
			RepairPutBetBonusByPKData(dayId, operatorID, appID, betBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetBonusByPKAsync(DateTime dayId, string operatorID, string appID, long betBonus, TransactionManager tm_ = null)
		{
			RepairPutBetBonusByPKData(dayId, operatorID, appID, betBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetBonusByPKData(DateTime dayId, string operatorID, string appID, long betBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBonus(long betBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus";
			var parameter_ = Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetBonusAsync(long betBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus";
			var parameter_ = Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetBonus
		#region PutWinCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinCountByPK(DateTime dayId, string operatorID, string appID, int winCount, TransactionManager tm_ = null)
		{
			RepairPutWinCountByPKData(dayId, operatorID, appID, winCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinCountByPKAsync(DateTime dayId, string operatorID, string appID, int winCount, TransactionManager tm_ = null)
		{
			RepairPutWinCountByPKData(dayId, operatorID, appID, winCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinCountByPKData(DateTime dayId, string operatorID, string appID, int winCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinCount` = @WinCount  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinCount(int winCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinCount` = @WinCount";
			var parameter_ = Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinCountAsync(int winCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinCount` = @WinCount";
			var parameter_ = Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinCount
		#region PutWinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinAmountByPK(DateTime dayId, string operatorID, string appID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(dayId, operatorID, appID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinAmountByPKAsync(DateTime dayId, string operatorID, string appID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(dayId, operatorID, appID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinAmountByPKData(DateTime dayId, string operatorID, string appID, long winAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinAmount(long winAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount";
			var parameter_ = Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinAmountAsync(long winAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount";
			var parameter_ = Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinAmount
		#region PutWinBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinBonusByPK(DateTime dayId, string operatorID, string appID, long winBonus, TransactionManager tm_ = null)
		{
			RepairPutWinBonusByPKData(dayId, operatorID, appID, winBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinBonusByPKAsync(DateTime dayId, string operatorID, string appID, long winBonus, TransactionManager tm_ = null)
		{
			RepairPutWinBonusByPKData(dayId, operatorID, appID, winBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinBonusByPKData(DateTime dayId, string operatorID, string appID, long winBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinBonus(long winBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus";
			var parameter_ = Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinBonusAsync(long winBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus";
			var parameter_ = Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinBonus
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(DateTime dayId, string operatorID, string appID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayId, operatorID, appID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(DateTime dayId, string operatorID, string appID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayId, operatorID, appID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(DateTime dayId, string operatorID, string appID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
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
		public bool Set(Sr_oper_app_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayId, item.OperatorID, item.AppID) == null)
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
		public async Task<bool> SetAsync(Sr_oper_app_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayId, item.OperatorID, item.AppID) == null)
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
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sr_oper_app_dayEO GetByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayId, operatorID, appID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<Sr_oper_app_dayEO> GetByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayId, operatorID, appID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime dayId, string operatorID, string appID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 DayId（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIdByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`DayId`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<DateTime> GetDayIdByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`DayId`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProviderID（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProviderIDByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProviderID`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetProviderIDByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProviderID`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetUsers（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBetUsersByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`BetUsers`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<int> GetBetUsersByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`BetUsers`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NewBetUsers（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetNewBetUsersByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`NewBetUsers`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<int> GetNewBetUsersByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`NewBetUsers`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NewUserBetAmount（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetNewUserBetAmountByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`NewUserBetAmount`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<long> GetNewUserBetAmountByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`NewUserBetAmount`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NewUserWinAmount（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetNewUserWinAmountByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`NewUserWinAmount`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<long> GetNewUserWinAmountByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`NewUserWinAmount`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NewUserBetBonus（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetNewUserBetBonusByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`NewUserBetBonus`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<long> GetNewUserBetBonusByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`NewUserBetBonus`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NewUserWinBonus（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetNewUserWinBonusByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`NewUserWinBonus`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<long> GetNewUserWinBonusByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`NewUserWinBonus`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetCount（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBetCountByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`BetCount`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<int> GetBetCountByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`BetCount`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetAmount（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetAmountByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetAmount`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<long> GetBetAmountByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetAmount`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetBonus（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetBonusByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetBonus`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<long> GetBetBonusByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetBonus`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinCount（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWinCountByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`WinCount`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<int> GetWinCountByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`WinCount`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinAmount（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinAmountByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinAmount`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<long> GetWinAmountByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinAmount`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinBonus（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinBonusByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinBonus`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<long> GetWinBonusByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinBonus`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(DateTime dayId, string operatorID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DayId` = @DayId AND `OperatorID` = @OperatorID AND `AppID` = @AppID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDayId
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByDayId(DateTime dayId)
		{
			return GetByDayId(dayId, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByDayIdAsync(DateTime dayId)
		{
			return await GetByDayIdAsync(dayId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByDayId(DateTime dayId, TransactionManager tm_)
		{
			return GetByDayId(dayId, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByDayIdAsync(DateTime dayId, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByDayId(DateTime dayId, int top_)
		{
			return GetByDayId(dayId, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByDayIdAsync(DateTime dayId, int top_)
		{
			return await GetByDayIdAsync(dayId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByDayId(DateTime dayId, int top_, TransactionManager tm_)
		{
			return GetByDayId(dayId, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByDayIdAsync(DateTime dayId, int top_, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByDayId(DateTime dayId, string sort_)
		{
			return GetByDayId(dayId, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByDayIdAsync(DateTime dayId, string sort_)
		{
			return await GetByDayIdAsync(dayId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByDayId(DateTime dayId, string sort_, TransactionManager tm_)
		{
			return GetByDayId(dayId, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByDayIdAsync(DateTime dayId, string sort_, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByDayId(DateTime dayId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayId` = @DayId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByDayIdAsync(DateTime dayId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayId` = @DayId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByDayId
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sr_oper_app_dayEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sr_oper_app_dayEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sr_oper_app_dayEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByAppIDAsync(string appID, int top_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByAppIDAsync(string appID, string sort_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByProviderID
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByProviderID(string providerID)
		{
			return GetByProviderID(providerID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByProviderIDAsync(string providerID)
		{
			return await GetByProviderIDAsync(providerID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByProviderID(string providerID, TransactionManager tm_)
		{
			return GetByProviderID(providerID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByProviderIDAsync(string providerID, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByProviderID(string providerID, int top_)
		{
			return GetByProviderID(providerID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByProviderIDAsync(string providerID, int top_)
		{
			return await GetByProviderIDAsync(providerID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByProviderID(string providerID, int top_, TransactionManager tm_)
		{
			return GetByProviderID(providerID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByProviderIDAsync(string providerID, int top_, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByProviderID(string providerID, string sort_)
		{
			return GetByProviderID(providerID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByProviderIDAsync(string providerID, string sort_)
		{
			return await GetByProviderIDAsync(providerID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByProviderID(string providerID, string sort_, TransactionManager tm_)
		{
			return GetByProviderID(providerID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByProviderIDAsync(string providerID, string sort_, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByProviderID(string providerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByProviderIDAsync(string providerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByProviderID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCountryIDAsync(string countryID, int top_)
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
		public List<Sr_oper_app_dayEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCountryIDAsync(string countryID, string sort_)
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
		public List<Sr_oper_app_dayEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
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
		public List<Sr_oper_app_dayEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByBetUsers
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetUsers(int betUsers)
		{
			return GetByBetUsers(betUsers, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetUsersAsync(int betUsers)
		{
			return await GetByBetUsersAsync(betUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetUsers(int betUsers, TransactionManager tm_)
		{
			return GetByBetUsers(betUsers, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetUsersAsync(int betUsers, TransactionManager tm_)
		{
			return await GetByBetUsersAsync(betUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetUsers(int betUsers, int top_)
		{
			return GetByBetUsers(betUsers, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetUsersAsync(int betUsers, int top_)
		{
			return await GetByBetUsersAsync(betUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetUsers(int betUsers, int top_, TransactionManager tm_)
		{
			return GetByBetUsers(betUsers, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetUsersAsync(int betUsers, int top_, TransactionManager tm_)
		{
			return await GetByBetUsersAsync(betUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetUsers(int betUsers, string sort_)
		{
			return GetByBetUsers(betUsers, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetUsersAsync(int betUsers, string sort_)
		{
			return await GetByBetUsersAsync(betUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetUsers(int betUsers, string sort_, TransactionManager tm_)
		{
			return GetByBetUsers(betUsers, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetUsersAsync(int betUsers, string sort_, TransactionManager tm_)
		{
			return await GetByBetUsersAsync(betUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetUsers(int betUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetUsers` = @BetUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetUsersAsync(int betUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetUsers` = @BetUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByBetUsers
		#region GetByNewBetUsers
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewBetUsers(int newBetUsers)
		{
			return GetByNewBetUsers(newBetUsers, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewBetUsersAsync(int newBetUsers)
		{
			return await GetByNewBetUsersAsync(newBetUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewBetUsers(int newBetUsers, TransactionManager tm_)
		{
			return GetByNewBetUsers(newBetUsers, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewBetUsersAsync(int newBetUsers, TransactionManager tm_)
		{
			return await GetByNewBetUsersAsync(newBetUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewBetUsers(int newBetUsers, int top_)
		{
			return GetByNewBetUsers(newBetUsers, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewBetUsersAsync(int newBetUsers, int top_)
		{
			return await GetByNewBetUsersAsync(newBetUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewBetUsers(int newBetUsers, int top_, TransactionManager tm_)
		{
			return GetByNewBetUsers(newBetUsers, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewBetUsersAsync(int newBetUsers, int top_, TransactionManager tm_)
		{
			return await GetByNewBetUsersAsync(newBetUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewBetUsers(int newBetUsers, string sort_)
		{
			return GetByNewBetUsers(newBetUsers, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewBetUsersAsync(int newBetUsers, string sort_)
		{
			return await GetByNewBetUsersAsync(newBetUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewBetUsers(int newBetUsers, string sort_, TransactionManager tm_)
		{
			return GetByNewBetUsers(newBetUsers, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewBetUsersAsync(int newBetUsers, string sort_, TransactionManager tm_)
		{
			return await GetByNewBetUsersAsync(newBetUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewBetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "newBetUsers">新下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewBetUsers(int newBetUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewBetUsers` = @NewBetUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewBetUsers", newBetUsers, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewBetUsersAsync(int newBetUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewBetUsers` = @NewBetUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewBetUsers", newBetUsers, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByNewBetUsers
		#region GetByNewUserBetAmount
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetAmount(long newUserBetAmount)
		{
			return GetByNewUserBetAmount(newUserBetAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetAmountAsync(long newUserBetAmount)
		{
			return await GetByNewUserBetAmountAsync(newUserBetAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetAmount(long newUserBetAmount, TransactionManager tm_)
		{
			return GetByNewUserBetAmount(newUserBetAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetAmountAsync(long newUserBetAmount, TransactionManager tm_)
		{
			return await GetByNewUserBetAmountAsync(newUserBetAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetAmount(long newUserBetAmount, int top_)
		{
			return GetByNewUserBetAmount(newUserBetAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetAmountAsync(long newUserBetAmount, int top_)
		{
			return await GetByNewUserBetAmountAsync(newUserBetAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetAmount(long newUserBetAmount, int top_, TransactionManager tm_)
		{
			return GetByNewUserBetAmount(newUserBetAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetAmountAsync(long newUserBetAmount, int top_, TransactionManager tm_)
		{
			return await GetByNewUserBetAmountAsync(newUserBetAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetAmount(long newUserBetAmount, string sort_)
		{
			return GetByNewUserBetAmount(newUserBetAmount, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetAmountAsync(long newUserBetAmount, string sort_)
		{
			return await GetByNewUserBetAmountAsync(newUserBetAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetAmount(long newUserBetAmount, string sort_, TransactionManager tm_)
		{
			return GetByNewUserBetAmount(newUserBetAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetAmountAsync(long newUserBetAmount, string sort_, TransactionManager tm_)
		{
			return await GetByNewUserBetAmountAsync(newUserBetAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetAmount">新用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetAmount(long newUserBetAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserBetAmount` = @NewUserBetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserBetAmount", newUserBetAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetAmountAsync(long newUserBetAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserBetAmount` = @NewUserBetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserBetAmount", newUserBetAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByNewUserBetAmount
		#region GetByNewUserWinAmount
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinAmount(long newUserWinAmount)
		{
			return GetByNewUserWinAmount(newUserWinAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinAmountAsync(long newUserWinAmount)
		{
			return await GetByNewUserWinAmountAsync(newUserWinAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinAmount(long newUserWinAmount, TransactionManager tm_)
		{
			return GetByNewUserWinAmount(newUserWinAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinAmountAsync(long newUserWinAmount, TransactionManager tm_)
		{
			return await GetByNewUserWinAmountAsync(newUserWinAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinAmount(long newUserWinAmount, int top_)
		{
			return GetByNewUserWinAmount(newUserWinAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinAmountAsync(long newUserWinAmount, int top_)
		{
			return await GetByNewUserWinAmountAsync(newUserWinAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinAmount(long newUserWinAmount, int top_, TransactionManager tm_)
		{
			return GetByNewUserWinAmount(newUserWinAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinAmountAsync(long newUserWinAmount, int top_, TransactionManager tm_)
		{
			return await GetByNewUserWinAmountAsync(newUserWinAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinAmount(long newUserWinAmount, string sort_)
		{
			return GetByNewUserWinAmount(newUserWinAmount, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinAmountAsync(long newUserWinAmount, string sort_)
		{
			return await GetByNewUserWinAmountAsync(newUserWinAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinAmount(long newUserWinAmount, string sort_, TransactionManager tm_)
		{
			return GetByNewUserWinAmount(newUserWinAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinAmountAsync(long newUserWinAmount, string sort_, TransactionManager tm_)
		{
			return await GetByNewUserWinAmountAsync(newUserWinAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinAmount">新用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinAmount(long newUserWinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserWinAmount` = @NewUserWinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserWinAmount", newUserWinAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinAmountAsync(long newUserWinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserWinAmount` = @NewUserWinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserWinAmount", newUserWinAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByNewUserWinAmount
		#region GetByNewUserBetBonus
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetBonus(long newUserBetBonus)
		{
			return GetByNewUserBetBonus(newUserBetBonus, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetBonusAsync(long newUserBetBonus)
		{
			return await GetByNewUserBetBonusAsync(newUserBetBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetBonus(long newUserBetBonus, TransactionManager tm_)
		{
			return GetByNewUserBetBonus(newUserBetBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetBonusAsync(long newUserBetBonus, TransactionManager tm_)
		{
			return await GetByNewUserBetBonusAsync(newUserBetBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetBonus(long newUserBetBonus, int top_)
		{
			return GetByNewUserBetBonus(newUserBetBonus, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetBonusAsync(long newUserBetBonus, int top_)
		{
			return await GetByNewUserBetBonusAsync(newUserBetBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetBonus(long newUserBetBonus, int top_, TransactionManager tm_)
		{
			return GetByNewUserBetBonus(newUserBetBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetBonusAsync(long newUserBetBonus, int top_, TransactionManager tm_)
		{
			return await GetByNewUserBetBonusAsync(newUserBetBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetBonus(long newUserBetBonus, string sort_)
		{
			return GetByNewUserBetBonus(newUserBetBonus, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetBonusAsync(long newUserBetBonus, string sort_)
		{
			return await GetByNewUserBetBonusAsync(newUserBetBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetBonus(long newUserBetBonus, string sort_, TransactionManager tm_)
		{
			return GetByNewUserBetBonus(newUserBetBonus, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetBonusAsync(long newUserBetBonus, string sort_, TransactionManager tm_)
		{
			return await GetByNewUserBetBonusAsync(newUserBetBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserBetBonus">新用户下注的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserBetBonus(long newUserBetBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserBetBonus` = @NewUserBetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserBetBonus", newUserBetBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserBetBonusAsync(long newUserBetBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserBetBonus` = @NewUserBetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserBetBonus", newUserBetBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByNewUserBetBonus
		#region GetByNewUserWinBonus
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinBonus(long newUserWinBonus)
		{
			return GetByNewUserWinBonus(newUserWinBonus, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinBonusAsync(long newUserWinBonus)
		{
			return await GetByNewUserWinBonusAsync(newUserWinBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinBonus(long newUserWinBonus, TransactionManager tm_)
		{
			return GetByNewUserWinBonus(newUserWinBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinBonusAsync(long newUserWinBonus, TransactionManager tm_)
		{
			return await GetByNewUserWinBonusAsync(newUserWinBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinBonus(long newUserWinBonus, int top_)
		{
			return GetByNewUserWinBonus(newUserWinBonus, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinBonusAsync(long newUserWinBonus, int top_)
		{
			return await GetByNewUserWinBonusAsync(newUserWinBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinBonus(long newUserWinBonus, int top_, TransactionManager tm_)
		{
			return GetByNewUserWinBonus(newUserWinBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinBonusAsync(long newUserWinBonus, int top_, TransactionManager tm_)
		{
			return await GetByNewUserWinBonusAsync(newUserWinBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinBonus(long newUserWinBonus, string sort_)
		{
			return GetByNewUserWinBonus(newUserWinBonus, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinBonusAsync(long newUserWinBonus, string sort_)
		{
			return await GetByNewUserWinBonusAsync(newUserWinBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinBonus(long newUserWinBonus, string sort_, TransactionManager tm_)
		{
			return GetByNewUserWinBonus(newUserWinBonus, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinBonusAsync(long newUserWinBonus, string sort_, TransactionManager tm_)
		{
			return await GetByNewUserWinBonusAsync(newUserWinBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewUserWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "newUserWinBonus">新用户返奖bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByNewUserWinBonus(long newUserWinBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserWinBonus` = @NewUserWinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserWinBonus", newUserWinBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByNewUserWinBonusAsync(long newUserWinBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewUserWinBonus` = @NewUserWinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewUserWinBonus", newUserWinBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByNewUserWinBonus
		#region GetByBetCount
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetCount(int betCount)
		{
			return GetByBetCount(betCount, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetCountAsync(int betCount)
		{
			return await GetByBetCountAsync(betCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetCount(int betCount, TransactionManager tm_)
		{
			return GetByBetCount(betCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetCountAsync(int betCount, TransactionManager tm_)
		{
			return await GetByBetCountAsync(betCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetCount(int betCount, int top_)
		{
			return GetByBetCount(betCount, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetCountAsync(int betCount, int top_)
		{
			return await GetByBetCountAsync(betCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetCount(int betCount, int top_, TransactionManager tm_)
		{
			return GetByBetCount(betCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetCountAsync(int betCount, int top_, TransactionManager tm_)
		{
			return await GetByBetCountAsync(betCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetCount(int betCount, string sort_)
		{
			return GetByBetCount(betCount, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetCountAsync(int betCount, string sort_)
		{
			return await GetByBetCountAsync(betCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetCount(int betCount, string sort_, TransactionManager tm_)
		{
			return GetByBetCount(betCount, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetCountAsync(int betCount, string sort_, TransactionManager tm_)
		{
			return await GetByBetCountAsync(betCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetCount(int betCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCount` = @BetCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetCountAsync(int betCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCount` = @BetCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByBetCount
		#region GetByBetAmount
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetAmount(long betAmount)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetAmountAsync(long betAmount)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetAmount(long betAmount, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetAmountAsync(long betAmount, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetAmount(long betAmount, int top_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetAmountAsync(long betAmount, int top_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetAmount(long betAmount, int top_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetAmountAsync(long betAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetAmount(long betAmount, string sort_)
		{
			return GetByBetAmount(betAmount, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetAmountAsync(long betAmount, string sort_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetAmount(long betAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetAmountAsync(long betAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetAmount(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetAmountAsync(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByBetAmount
		#region GetByBetBonus
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetBonus(long betBonus)
		{
			return GetByBetBonus(betBonus, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetBonusAsync(long betBonus)
		{
			return await GetByBetBonusAsync(betBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetBonus(long betBonus, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetBonusAsync(long betBonus, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetBonus(long betBonus, int top_)
		{
			return GetByBetBonus(betBonus, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetBonusAsync(long betBonus, int top_)
		{
			return await GetByBetBonusAsync(betBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetBonus(long betBonus, int top_, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetBonusAsync(long betBonus, int top_, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetBonus(long betBonus, string sort_)
		{
			return GetByBetBonus(betBonus, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetBonusAsync(long betBonus, string sort_)
		{
			return await GetByBetBonusAsync(betBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetBonus(long betBonus, string sort_, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetBonusAsync(long betBonus, string sort_, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByBetBonus(long betBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonus` = @BetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByBetBonusAsync(long betBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonus` = @BetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByBetBonus
		#region GetByWinCount
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinCount(int winCount)
		{
			return GetByWinCount(winCount, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinCountAsync(int winCount)
		{
			return await GetByWinCountAsync(winCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinCount(int winCount, TransactionManager tm_)
		{
			return GetByWinCount(winCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinCountAsync(int winCount, TransactionManager tm_)
		{
			return await GetByWinCountAsync(winCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinCount(int winCount, int top_)
		{
			return GetByWinCount(winCount, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinCountAsync(int winCount, int top_)
		{
			return await GetByWinCountAsync(winCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinCount(int winCount, int top_, TransactionManager tm_)
		{
			return GetByWinCount(winCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinCountAsync(int winCount, int top_, TransactionManager tm_)
		{
			return await GetByWinCountAsync(winCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinCount(int winCount, string sort_)
		{
			return GetByWinCount(winCount, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinCountAsync(int winCount, string sort_)
		{
			return await GetByWinCountAsync(winCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinCount(int winCount, string sort_, TransactionManager tm_)
		{
			return GetByWinCount(winCount, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinCountAsync(int winCount, string sort_, TransactionManager tm_)
		{
			return await GetByWinCountAsync(winCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinCount(int winCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCount` = @WinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinCountAsync(int winCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCount` = @WinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByWinCount
		#region GetByWinAmount
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinAmount(long winAmount)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinAmountAsync(long winAmount)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinAmount(long winAmount, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinAmountAsync(long winAmount, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinAmount(long winAmount, int top_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinAmountAsync(long winAmount, int top_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinAmount(long winAmount, int top_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinAmountAsync(long winAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinAmount(long winAmount, string sort_)
		{
			return GetByWinAmount(winAmount, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinAmountAsync(long winAmount, string sort_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinAmount(long winAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinAmountAsync(long winAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinAmount(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinAmountAsync(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByWinAmount
		#region GetByWinBonus
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinBonus(long winBonus)
		{
			return GetByWinBonus(winBonus, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinBonusAsync(long winBonus)
		{
			return await GetByWinBonusAsync(winBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinBonus(long winBonus, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinBonusAsync(long winBonus, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinBonus(long winBonus, int top_)
		{
			return GetByWinBonus(winBonus, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinBonusAsync(long winBonus, int top_)
		{
			return await GetByWinBonusAsync(winBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinBonus(long winBonus, int top_, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinBonusAsync(long winBonus, int top_, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinBonus(long winBonus, string sort_)
		{
			return GetByWinBonus(winBonus, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinBonusAsync(long winBonus, string sort_)
		{
			return await GetByWinBonusAsync(winBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinBonus(long winBonus, string sort_, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinBonusAsync(long winBonus, string sort_, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByWinBonus(long winBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonus` = @WinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByWinBonusAsync(long winBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonus` = @WinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByWinBonus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sr_oper_app_dayEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_app_dayEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sr_oper_app_dayEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sr_oper_app_dayEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_app_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_app_dayEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
