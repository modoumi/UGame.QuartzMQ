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
	/// 【表 sr_prov_day 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sr_prov_dayEO : IRowMapper<Sr_prov_dayEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sr_prov_dayEO()
		{
			this.BetUsers = 0;
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
		
		private string _originalProviderID;
		/// <summary>
		/// 【数据库中的原始主键 ProviderID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalProviderID
		{
			get { return _originalProviderID; }
			set { HasOriginal = true; _originalProviderID = value; }
		}
		
		private string _originalCountryID;
		/// <summary>
		/// 【数据库中的原始主键 CountryID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalCountryID
		{
			get { return _originalCountryID; }
			set { HasOriginal = true; _originalCountryID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DayId", DayId },  { "ProviderID", ProviderID },  { "CountryID", CountryID }, };
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
		/// 应用提供商
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string ProviderID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CountryID { get; set; }
		/// <summary>
		/// 货币类型（仅现金，其它另行统计）
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 下注用户数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int BetUsers { get; set; }
		/// <summary>
		/// 下注次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int BetCount { get; set; }
		/// <summary>
		/// 当天用户下注额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long BetAmount { get; set; }
		/// <summary>
		/// 当天用户bonus下注
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long BetBonus { get; set; }
		/// <summary>
		/// 返奖次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int WinCount { get; set; }
		/// <summary>
		/// 当天用户返奖额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long WinAmount { get; set; }
		/// <summary>
		/// 当天用户bonus返奖
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 11)]
		public long WinBonus { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 12)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sr_prov_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sr_prov_dayEO MapDataReader(IDataReader reader)
		{
		    Sr_prov_dayEO ret = new Sr_prov_dayEO();
			ret.DayId = reader.ToDateTime("DayId");
			ret.OriginalDayId = ret.DayId;
			ret.ProviderID = reader.ToString("ProviderID");
			ret.OriginalProviderID = ret.ProviderID;
			ret.CountryID = reader.ToString("CountryID");
			ret.OriginalCountryID = ret.CountryID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.BetUsers = reader.ToInt32("BetUsers");
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
	/// 【表 sr_prov_day 的操作类】
	/// </summary>
	[Obsolete]
	public class Sr_prov_dayMO : MySqlTableMO<Sr_prov_dayEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sr_prov_day`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sr_prov_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sr_prov_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sr_prov_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sr_prov_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sr_prov_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sr_prov_dayEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DayId`, `ProviderID`, `CountryID`, `CurrencyID`, `BetUsers`, `BetCount`, `BetAmount`, `BetBonus`, `WinCount`, `WinAmount`, `WinBonus`, `RecDate`) VALUE (@DayId, @ProviderID, @CountryID, @CurrencyID, @BetUsers, @BetCount, @BetAmount, @BetBonus, @WinCount, @WinAmount, @WinBonus, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", item.ProviderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetUsers", item.BetUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@BetCount", item.BetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonus", item.BetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@WinCount", item.WinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonus", item.WinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sr_prov_dayEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sr_prov_dayEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sr_prov_dayEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DayId`, `ProviderID`, `CountryID`, `CurrencyID`, `BetUsers`, `BetCount`, `BetAmount`, `BetBonus`, `WinCount`, `WinAmount`, `WinBonus`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DayId.ToString("yyyy-MM-dd HH:mm:ss")}','{item.ProviderID}','{item.CountryID}','{item.CurrencyID}',{item.BetUsers},{item.BetCount},{item.BetAmount},{item.BetBonus},{item.WinCount},{item.WinAmount},{item.WinBonus},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayId, providerID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayId, providerID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime dayId, string providerID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sr_prov_dayEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DayId, item.ProviderID, item.CountryID, tm_);
		}
		public async Task<int> RemoveAsync(Sr_prov_dayEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DayId, item.ProviderID, item.CountryID, tm_);
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
			sql_ = $"DELETE FROM {TableName} WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByProviderID
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
			sql_ = $"DELETE FROM {TableName} WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryID
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
		public int Put(Sr_prov_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sr_prov_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sr_prov_dayEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayId` = @DayId, `ProviderID` = @ProviderID, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `BetUsers` = @BetUsers, `BetCount` = @BetCount, `BetAmount` = @BetAmount, `BetBonus` = @BetBonus, `WinCount` = @WinCount, `WinAmount` = @WinAmount, `WinBonus` = @WinBonus WHERE `DayId` = @DayId_Original AND `ProviderID` = @ProviderID_Original AND `CountryID` = @CountryID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", item.ProviderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetUsers", item.BetUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@BetCount", item.BetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonus", item.BetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@WinCount", item.WinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonus", item.WinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId_Original", item.HasOriginal ? item.OriginalDayId : item.DayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID_Original", item.HasOriginal ? item.OriginalProviderID : item.ProviderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID_Original", item.HasOriginal ? item.OriginalCountryID : item.CountryID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sr_prov_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sr_prov_dayEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayId, string providerID, string countryID, string set_, params object[] values_)
		{
			return Put(set_, "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", ConcatValues(values_, dayId, providerID, countryID));
		}
		public async Task<int> PutByPKAsync(DateTime dayId, string providerID, string countryID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", ConcatValues(values_, dayId, providerID, countryID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayId, string providerID, string countryID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", tm_, ConcatValues(values_, dayId, providerID, countryID));
		}
		public async Task<int> PutByPKAsync(DateTime dayId, string providerID, string countryID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", tm_, ConcatValues(values_, dayId, providerID, countryID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayId, string providerID, string countryID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime dayId, string providerID, string countryID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutProviderID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderID(string providerID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID";
			var parameter_ = Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProviderIDAsync(string providerID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID";
			var parameter_ = Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProviderID
		#region PutCountryID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryID(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryID
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(DateTime dayId, string providerID, string countryID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(dayId, providerID, countryID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(DateTime dayId, string providerID, string countryID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(dayId, providerID, countryID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(DateTime dayId, string providerID, string countryID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
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
		#region PutBetUsers
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetUsersByPK(DateTime dayId, string providerID, string countryID, int betUsers, TransactionManager tm_ = null)
		{
			RepairPutBetUsersByPKData(dayId, providerID, countryID, betUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetUsersByPKAsync(DateTime dayId, string providerID, string countryID, int betUsers, TransactionManager tm_ = null)
		{
			RepairPutBetUsersByPKData(dayId, providerID, countryID, betUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetUsersByPKData(DateTime dayId, string providerID, string countryID, int betUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetUsers` = @BetUsers  WHERE `DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
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
		#region PutBetCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetCountByPK(DateTime dayId, string providerID, string countryID, int betCount, TransactionManager tm_ = null)
		{
			RepairPutBetCountByPKData(dayId, providerID, countryID, betCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetCountByPKAsync(DateTime dayId, string providerID, string countryID, int betCount, TransactionManager tm_ = null)
		{
			RepairPutBetCountByPKData(dayId, providerID, countryID, betCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetCountByPKData(DateTime dayId, string providerID, string countryID, int betCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetCount` = @BetCount  WHERE `DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
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
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmountByPK(DateTime dayId, string providerID, string countryID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(dayId, providerID, countryID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetAmountByPKAsync(DateTime dayId, string providerID, string countryID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(dayId, providerID, countryID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetAmountByPKData(DateTime dayId, string providerID, string countryID, long betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount  WHERE `DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
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
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBonusByPK(DateTime dayId, string providerID, string countryID, long betBonus, TransactionManager tm_ = null)
		{
			RepairPutBetBonusByPKData(dayId, providerID, countryID, betBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetBonusByPKAsync(DateTime dayId, string providerID, string countryID, long betBonus, TransactionManager tm_ = null)
		{
			RepairPutBetBonusByPKData(dayId, providerID, countryID, betBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetBonusByPKData(DateTime dayId, string providerID, string countryID, long betBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus  WHERE `DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
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
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinCountByPK(DateTime dayId, string providerID, string countryID, int winCount, TransactionManager tm_ = null)
		{
			RepairPutWinCountByPKData(dayId, providerID, countryID, winCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinCountByPKAsync(DateTime dayId, string providerID, string countryID, int winCount, TransactionManager tm_ = null)
		{
			RepairPutWinCountByPKData(dayId, providerID, countryID, winCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinCountByPKData(DateTime dayId, string providerID, string countryID, int winCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinCount` = @WinCount  WHERE `DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
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
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinAmountByPK(DateTime dayId, string providerID, string countryID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(dayId, providerID, countryID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinAmountByPKAsync(DateTime dayId, string providerID, string countryID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(dayId, providerID, countryID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinAmountByPKData(DateTime dayId, string providerID, string countryID, long winAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount  WHERE `DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
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
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinBonusByPK(DateTime dayId, string providerID, string countryID, long winBonus, TransactionManager tm_ = null)
		{
			RepairPutWinBonusByPKData(dayId, providerID, countryID, winBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinBonusByPKAsync(DateTime dayId, string providerID, string countryID, long winBonus, TransactionManager tm_ = null)
		{
			RepairPutWinBonusByPKData(dayId, providerID, countryID, winBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinBonusByPKData(DateTime dayId, string providerID, string countryID, long winBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus  WHERE `DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
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
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(DateTime dayId, string providerID, string countryID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayId, providerID, countryID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(DateTime dayId, string providerID, string countryID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayId, providerID, countryID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(DateTime dayId, string providerID, string countryID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
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
		public bool Set(Sr_prov_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayId, item.ProviderID, item.CountryID) == null)
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
		public async Task<bool> SetAsync(Sr_prov_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayId, item.ProviderID, item.CountryID) == null)
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
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sr_prov_dayEO GetByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayId, providerID, countryID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<Sr_prov_dayEO> GetByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayId, providerID, countryID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime dayId, string providerID, string countryID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 DayId（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIdByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`DayId`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<DateTime> GetDayIdByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`DayId`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProviderID（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProviderIDByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProviderID`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<string> GetProviderIDByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProviderID`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetUsers（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBetUsersByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`BetUsers`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<int> GetBetUsersByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`BetUsers`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetCount（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBetCountByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`BetCount`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<int> GetBetCountByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`BetCount`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetAmount（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetAmountByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetAmount`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<long> GetBetAmountByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetAmount`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetBonus（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetBonusByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetBonus`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<long> GetBetBonusByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetBonus`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinCount（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWinCountByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`WinCount`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<int> GetWinCountByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`WinCount`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinAmount（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinAmountByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinAmount`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<long> GetWinAmountByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinAmount`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinBonus（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinBonusByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinBonus`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<long> GetWinBonusByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinBonus`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// /// <param name = "providerID">应用提供商</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(DateTime dayId, string providerID, string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DayId` = @DayId AND `ProviderID` = @ProviderID AND `CountryID` = @CountryID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDayId
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByDayId(DateTime dayId)
		{
			return GetByDayId(dayId, 0, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByDayIdAsync(DateTime dayId)
		{
			return await GetByDayIdAsync(dayId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByDayId(DateTime dayId, TransactionManager tm_)
		{
			return GetByDayId(dayId, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByDayIdAsync(DateTime dayId, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByDayId(DateTime dayId, int top_)
		{
			return GetByDayId(dayId, top_, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByDayIdAsync(DateTime dayId, int top_)
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
		public List<Sr_prov_dayEO> GetByDayId(DateTime dayId, int top_, TransactionManager tm_)
		{
			return GetByDayId(dayId, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByDayIdAsync(DateTime dayId, int top_, TransactionManager tm_)
		{
			return await GetByDayIdAsync(dayId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayId（字段） 查询
		/// </summary>
		/// /// <param name = "dayId">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByDayId(DateTime dayId, string sort_)
		{
			return GetByDayId(dayId, 0, sort_, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByDayIdAsync(DateTime dayId, string sort_)
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
		public List<Sr_prov_dayEO> GetByDayId(DateTime dayId, string sort_, TransactionManager tm_)
		{
			return GetByDayId(dayId, 0, sort_, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByDayIdAsync(DateTime dayId, string sort_, TransactionManager tm_)
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
		public List<Sr_prov_dayEO> GetByDayId(DateTime dayId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayId` = @DayId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<List<Sr_prov_dayEO>> GetByDayIdAsync(DateTime dayId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayId` = @DayId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayId", dayId, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		#endregion // GetByDayId
		#region GetByProviderID
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByProviderID(string providerID)
		{
			return GetByProviderID(providerID, 0, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByProviderIDAsync(string providerID)
		{
			return await GetByProviderIDAsync(providerID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByProviderID(string providerID, TransactionManager tm_)
		{
			return GetByProviderID(providerID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByProviderIDAsync(string providerID, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByProviderID(string providerID, int top_)
		{
			return GetByProviderID(providerID, top_, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByProviderIDAsync(string providerID, int top_)
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
		public List<Sr_prov_dayEO> GetByProviderID(string providerID, int top_, TransactionManager tm_)
		{
			return GetByProviderID(providerID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByProviderIDAsync(string providerID, int top_, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByProviderID(string providerID, string sort_)
		{
			return GetByProviderID(providerID, 0, sort_, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByProviderIDAsync(string providerID, string sort_)
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
		public List<Sr_prov_dayEO> GetByProviderID(string providerID, string sort_, TransactionManager tm_)
		{
			return GetByProviderID(providerID, 0, sort_, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByProviderIDAsync(string providerID, string sort_, TransactionManager tm_)
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
		public List<Sr_prov_dayEO> GetByProviderID(string providerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ProviderID` = @ProviderID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<List<Sr_prov_dayEO>> GetByProviderIDAsync(string providerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ProviderID` = @ProviderID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		#endregion // GetByProviderID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCountryIDAsync(string countryID, int top_)
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
		public List<Sr_prov_dayEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCountryIDAsync(string countryID, string sort_)
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
		public List<Sr_prov_dayEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
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
		public List<Sr_prov_dayEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Sr_prov_dayEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（仅现金，其它另行统计）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Sr_prov_dayEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Sr_prov_dayEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<List<Sr_prov_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByBetUsers
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetUsers(int betUsers)
		{
			return GetByBetUsers(betUsers, 0, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetUsersAsync(int betUsers)
		{
			return await GetByBetUsersAsync(betUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetUsers(int betUsers, TransactionManager tm_)
		{
			return GetByBetUsers(betUsers, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetUsersAsync(int betUsers, TransactionManager tm_)
		{
			return await GetByBetUsersAsync(betUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetUsers(int betUsers, int top_)
		{
			return GetByBetUsers(betUsers, top_, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetUsersAsync(int betUsers, int top_)
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
		public List<Sr_prov_dayEO> GetByBetUsers(int betUsers, int top_, TransactionManager tm_)
		{
			return GetByBetUsers(betUsers, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetUsersAsync(int betUsers, int top_, TransactionManager tm_)
		{
			return await GetByBetUsersAsync(betUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">下注用户数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetUsers(int betUsers, string sort_)
		{
			return GetByBetUsers(betUsers, 0, sort_, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetUsersAsync(int betUsers, string sort_)
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
		public List<Sr_prov_dayEO> GetByBetUsers(int betUsers, string sort_, TransactionManager tm_)
		{
			return GetByBetUsers(betUsers, 0, sort_, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetUsersAsync(int betUsers, string sort_, TransactionManager tm_)
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
		public List<Sr_prov_dayEO> GetByBetUsers(int betUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetUsers` = @BetUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetUsersAsync(int betUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetUsers` = @BetUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		#endregion // GetByBetUsers
		#region GetByBetCount
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetCount(int betCount)
		{
			return GetByBetCount(betCount, 0, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetCountAsync(int betCount)
		{
			return await GetByBetCountAsync(betCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetCount(int betCount, TransactionManager tm_)
		{
			return GetByBetCount(betCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetCountAsync(int betCount, TransactionManager tm_)
		{
			return await GetByBetCountAsync(betCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetCount(int betCount, int top_)
		{
			return GetByBetCount(betCount, top_, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetCountAsync(int betCount, int top_)
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
		public List<Sr_prov_dayEO> GetByBetCount(int betCount, int top_, TransactionManager tm_)
		{
			return GetByBetCount(betCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetCountAsync(int betCount, int top_, TransactionManager tm_)
		{
			return await GetByBetCountAsync(betCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCount（字段） 查询
		/// </summary>
		/// /// <param name = "betCount">下注次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetCount(int betCount, string sort_)
		{
			return GetByBetCount(betCount, 0, sort_, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetCountAsync(int betCount, string sort_)
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
		public List<Sr_prov_dayEO> GetByBetCount(int betCount, string sort_, TransactionManager tm_)
		{
			return GetByBetCount(betCount, 0, sort_, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetCountAsync(int betCount, string sort_, TransactionManager tm_)
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
		public List<Sr_prov_dayEO> GetByBetCount(int betCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCount` = @BetCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetCountAsync(int betCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCount` = @BetCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCount", betCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		#endregion // GetByBetCount
		#region GetByBetAmount
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetAmount(long betAmount)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetAmountAsync(long betAmount)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetAmount(long betAmount, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetAmountAsync(long betAmount, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetAmount(long betAmount, int top_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetAmountAsync(long betAmount, int top_)
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
		public List<Sr_prov_dayEO> GetByBetAmount(long betAmount, int top_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetAmountAsync(long betAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">当天用户下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetAmount(long betAmount, string sort_)
		{
			return GetByBetAmount(betAmount, 0, sort_, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetAmountAsync(long betAmount, string sort_)
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
		public List<Sr_prov_dayEO> GetByBetAmount(long betAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetAmountAsync(long betAmount, string sort_, TransactionManager tm_)
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
		public List<Sr_prov_dayEO> GetByBetAmount(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetAmountAsync(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		#endregion // GetByBetAmount
		#region GetByBetBonus
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetBonus(long betBonus)
		{
			return GetByBetBonus(betBonus, 0, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetBonusAsync(long betBonus)
		{
			return await GetByBetBonusAsync(betBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetBonus(long betBonus, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetBonusAsync(long betBonus, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetBonus(long betBonus, int top_)
		{
			return GetByBetBonus(betBonus, top_, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetBonusAsync(long betBonus, int top_)
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
		public List<Sr_prov_dayEO> GetByBetBonus(long betBonus, int top_, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetBonusAsync(long betBonus, int top_, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">当天用户bonus下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByBetBonus(long betBonus, string sort_)
		{
			return GetByBetBonus(betBonus, 0, sort_, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetBonusAsync(long betBonus, string sort_)
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
		public List<Sr_prov_dayEO> GetByBetBonus(long betBonus, string sort_, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, 0, sort_, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetBonusAsync(long betBonus, string sort_, TransactionManager tm_)
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
		public List<Sr_prov_dayEO> GetByBetBonus(long betBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonus` = @BetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<List<Sr_prov_dayEO>> GetByBetBonusAsync(long betBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonus` = @BetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		#endregion // GetByBetBonus
		#region GetByWinCount
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByWinCount(int winCount)
		{
			return GetByWinCount(winCount, 0, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinCountAsync(int winCount)
		{
			return await GetByWinCountAsync(winCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByWinCount(int winCount, TransactionManager tm_)
		{
			return GetByWinCount(winCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinCountAsync(int winCount, TransactionManager tm_)
		{
			return await GetByWinCountAsync(winCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByWinCount(int winCount, int top_)
		{
			return GetByWinCount(winCount, top_, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinCountAsync(int winCount, int top_)
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
		public List<Sr_prov_dayEO> GetByWinCount(int winCount, int top_, TransactionManager tm_)
		{
			return GetByWinCount(winCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinCountAsync(int winCount, int top_, TransactionManager tm_)
		{
			return await GetByWinCountAsync(winCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCount（字段） 查询
		/// </summary>
		/// /// <param name = "winCount">返奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByWinCount(int winCount, string sort_)
		{
			return GetByWinCount(winCount, 0, sort_, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinCountAsync(int winCount, string sort_)
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
		public List<Sr_prov_dayEO> GetByWinCount(int winCount, string sort_, TransactionManager tm_)
		{
			return GetByWinCount(winCount, 0, sort_, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinCountAsync(int winCount, string sort_, TransactionManager tm_)
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
		public List<Sr_prov_dayEO> GetByWinCount(int winCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCount` = @WinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinCountAsync(int winCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCount` = @WinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCount", winCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		#endregion // GetByWinCount
		#region GetByWinAmount
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByWinAmount(long winAmount)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinAmountAsync(long winAmount)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByWinAmount(long winAmount, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinAmountAsync(long winAmount, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByWinAmount(long winAmount, int top_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinAmountAsync(long winAmount, int top_)
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
		public List<Sr_prov_dayEO> GetByWinAmount(long winAmount, int top_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinAmountAsync(long winAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">当天用户返奖额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByWinAmount(long winAmount, string sort_)
		{
			return GetByWinAmount(winAmount, 0, sort_, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinAmountAsync(long winAmount, string sort_)
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
		public List<Sr_prov_dayEO> GetByWinAmount(long winAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, sort_, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinAmountAsync(long winAmount, string sort_, TransactionManager tm_)
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
		public List<Sr_prov_dayEO> GetByWinAmount(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinAmountAsync(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		#endregion // GetByWinAmount
		#region GetByWinBonus
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByWinBonus(long winBonus)
		{
			return GetByWinBonus(winBonus, 0, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinBonusAsync(long winBonus)
		{
			return await GetByWinBonusAsync(winBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByWinBonus(long winBonus, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinBonusAsync(long winBonus, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByWinBonus(long winBonus, int top_)
		{
			return GetByWinBonus(winBonus, top_, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinBonusAsync(long winBonus, int top_)
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
		public List<Sr_prov_dayEO> GetByWinBonus(long winBonus, int top_, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinBonusAsync(long winBonus, int top_, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">当天用户bonus返奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByWinBonus(long winBonus, string sort_)
		{
			return GetByWinBonus(winBonus, 0, sort_, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinBonusAsync(long winBonus, string sort_)
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
		public List<Sr_prov_dayEO> GetByWinBonus(long winBonus, string sort_, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, 0, sort_, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinBonusAsync(long winBonus, string sort_, TransactionManager tm_)
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
		public List<Sr_prov_dayEO> GetByWinBonus(long winBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonus` = @WinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<List<Sr_prov_dayEO>> GetByWinBonusAsync(long winBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonus` = @WinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		#endregion // GetByWinBonus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sr_prov_dayEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_prov_dayEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sr_prov_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sr_prov_dayEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sr_prov_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sr_prov_dayEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		public async Task<List<Sr_prov_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_prov_dayEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
