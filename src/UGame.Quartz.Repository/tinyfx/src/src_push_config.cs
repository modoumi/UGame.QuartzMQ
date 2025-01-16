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
	/// 风控配置表
	/// 【表 src_push_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Src_push_configEO : IRowMapper<Src_push_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Src_push_configEO()
		{
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalCfgID;
		/// <summary>
		/// 【数据库中的原始主键 CfgID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalCfgID
		{
			get { return _originalCfgID; }
			set { HasOriginal = true; _originalCfgID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "CfgID", CfgID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 键Key
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string CfgID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CountryId { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 游戏净盈利/净亏损limit
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int? GameTop { get; set; }
		/// <summary>
		/// 用户净盈利/净亏损limit
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int? UserTop { get; set; }
		/// <summary>
		/// 数据重置时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 7)]
		public DateTime ResetTime { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 8)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Src_push_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Src_push_configEO MapDataReader(IDataReader reader)
		{
		    Src_push_configEO ret = new Src_push_configEO();
			ret.CfgID = reader.ToString("CfgID");
			ret.OriginalCfgID = ret.CfgID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.GameTop = reader.ToInt32N("GameTop");
			ret.UserTop = reader.ToInt32N("UserTop");
			ret.ResetTime = reader.ToDateTime("ResetTime");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 风控配置表
	/// 【表 src_push_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Src_push_configMO : MySqlTableMO<Src_push_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`src_push_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Src_push_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Src_push_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Src_push_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Src_push_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Src_push_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Src_push_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`CfgID`, `OperatorID`, `CountryId`, `CurrencyID`, `GameTop`, `UserTop`, `ResetTime`, `RecDate`) VALUE (@CfgID, @OperatorID, @CountryId, @CurrencyID, @GameTop, @UserTop, @ResetTime, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", item.CfgID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId != null ? item.CountryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@GameTop", item.GameTop.HasValue ? item.GameTop.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@UserTop", item.UserTop.HasValue ? item.UserTop.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@ResetTime", item.ResetTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Src_push_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Src_push_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Src_push_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`CfgID`, `OperatorID`, `CountryId`, `CurrencyID`, `GameTop`, `UserTop`, `ResetTime`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.CfgID}','{item.OperatorID}','{item.CountryId}','{item.CurrencyID}',{item.GameTop?.ToString()??null},{item.UserTop?.ToString()??null},'{item.ResetTime.ToString("yyyy-MM-dd HH:mm:ss")}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "cfgID">键Key</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string cfgID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(cfgID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string cfgID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(cfgID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string cfgID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CfgID` = @CfgID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Src_push_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.CfgID, tm_);
		}
		public async Task<int> RemoveAsync(Src_push_configEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.CfgID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		#region RemoveByCountryId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryId(string countryId, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIdData(countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryIdAsync(string countryId, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIdData(countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryIdData(string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (countryId != null ? "`CountryId` = @CountryId" : "`CountryId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (countryId != null)
				paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryId
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
		#region RemoveByGameTop
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "gameTop">游戏净盈利/净亏损limit</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByGameTop(int? gameTop, TransactionManager tm_ = null)
		{
			RepairRemoveByGameTopData(gameTop.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByGameTopAsync(int? gameTop, TransactionManager tm_ = null)
		{
			RepairRemoveByGameTopData(gameTop.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByGameTopData(int? gameTop, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (gameTop.HasValue ? "`GameTop` = @GameTop" : "`GameTop` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (gameTop.HasValue)
				paras_.Add(Database.CreateInParameter("@GameTop", gameTop.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByGameTop
		#region RemoveByUserTop
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userTop">用户净盈利/净亏损limit</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserTop(int? userTop, TransactionManager tm_ = null)
		{
			RepairRemoveByUserTopData(userTop.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserTopAsync(int? userTop, TransactionManager tm_ = null)
		{
			RepairRemoveByUserTopData(userTop.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserTopData(int? userTop, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (userTop.HasValue ? "`UserTop` = @UserTop" : "`UserTop` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (userTop.HasValue)
				paras_.Add(Database.CreateInParameter("@UserTop", userTop.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserTop
		#region RemoveByResetTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "resetTime">数据重置时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByResetTime(DateTime resetTime, TransactionManager tm_ = null)
		{
			RepairRemoveByResetTimeData(resetTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByResetTimeAsync(DateTime resetTime, TransactionManager tm_ = null)
		{
			RepairRemoveByResetTimeData(resetTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByResetTimeData(DateTime resetTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ResetTime` = @ResetTime";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ResetTime", resetTime, MySqlDbType.DateTime));
		}
		#endregion // RemoveByResetTime
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
		public int Put(Src_push_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Src_push_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Src_push_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CfgID` = @CfgID, `OperatorID` = @OperatorID, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `GameTop` = @GameTop, `UserTop` = @UserTop, `ResetTime` = @ResetTime WHERE `CfgID` = @CfgID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", item.CfgID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryId", item.CountryId != null ? item.CountryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@GameTop", item.GameTop.HasValue ? item.GameTop.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@UserTop", item.UserTop.HasValue ? item.UserTop.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@ResetTime", item.ResetTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@CfgID_Original", item.HasOriginal ? item.OriginalCfgID : item.CfgID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Src_push_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Src_push_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "cfgID">键Key</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string cfgID, string set_, params object[] values_)
		{
			return Put(set_, "`CfgID` = @CfgID", ConcatValues(values_, cfgID));
		}
		public async Task<int> PutByPKAsync(string cfgID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`CfgID` = @CfgID", ConcatValues(values_, cfgID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string cfgID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`CfgID` = @CfgID", tm_, ConcatValues(values_, cfgID));
		}
		public async Task<int> PutByPKAsync(string cfgID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`CfgID` = @CfgID", tm_, ConcatValues(values_, cfgID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string cfgID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`CfgID` = @CfgID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string cfgID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`CfgID` = @CfgID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string cfgID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(cfgID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string cfgID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(cfgID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string cfgID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `CfgID` = @CfgID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
		}
	 
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
		#region PutCountryId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIdByPK(string cfgID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(cfgID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIdByPKAsync(string cfgID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(cfgID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIdByPKData(string cfgID, string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId  WHERE `CfgID` = @CfgID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryId", countryId != null ? countryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryId(string countryId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId";
			var parameter_ = Database.CreateInParameter("@CountryId", countryId != null ? countryId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIdAsync(string countryId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId";
			var parameter_ = Database.CreateInParameter("@CountryId", countryId != null ? countryId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryId
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string cfgID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(cfgID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string cfgID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(cfgID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string cfgID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `CfgID` = @CfgID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
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
		#region PutGameTop
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// /// <param name = "gameTop">游戏净盈利/净亏损limit</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGameTopByPK(string cfgID, int? gameTop, TransactionManager tm_ = null)
		{
			RepairPutGameTopByPKData(cfgID, gameTop, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGameTopByPKAsync(string cfgID, int? gameTop, TransactionManager tm_ = null)
		{
			RepairPutGameTopByPKData(cfgID, gameTop, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGameTopByPKData(string cfgID, int? gameTop, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `GameTop` = @GameTop  WHERE `CfgID` = @CfgID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@GameTop", gameTop.HasValue ? gameTop.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "gameTop">游戏净盈利/净亏损limit</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGameTop(int? gameTop, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GameTop` = @GameTop";
			var parameter_ = Database.CreateInParameter("@GameTop", gameTop.HasValue ? gameTop.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGameTopAsync(int? gameTop, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GameTop` = @GameTop";
			var parameter_ = Database.CreateInParameter("@GameTop", gameTop.HasValue ? gameTop.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGameTop
		#region PutUserTop
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// /// <param name = "userTop">用户净盈利/净亏损limit</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserTopByPK(string cfgID, int? userTop, TransactionManager tm_ = null)
		{
			RepairPutUserTopByPKData(cfgID, userTop, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserTopByPKAsync(string cfgID, int? userTop, TransactionManager tm_ = null)
		{
			RepairPutUserTopByPKData(cfgID, userTop, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserTopByPKData(string cfgID, int? userTop, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserTop` = @UserTop  WHERE `CfgID` = @CfgID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserTop", userTop.HasValue ? userTop.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userTop">用户净盈利/净亏损limit</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserTop(int? userTop, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserTop` = @UserTop";
			var parameter_ = Database.CreateInParameter("@UserTop", userTop.HasValue ? userTop.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserTopAsync(int? userTop, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserTop` = @UserTop";
			var parameter_ = Database.CreateInParameter("@UserTop", userTop.HasValue ? userTop.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserTop
		#region PutResetTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// /// <param name = "resetTime">数据重置时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutResetTimeByPK(string cfgID, DateTime resetTime, TransactionManager tm_ = null)
		{
			RepairPutResetTimeByPKData(cfgID, resetTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutResetTimeByPKAsync(string cfgID, DateTime resetTime, TransactionManager tm_ = null)
		{
			RepairPutResetTimeByPKData(cfgID, resetTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutResetTimeByPKData(string cfgID, DateTime resetTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ResetTime` = @ResetTime  WHERE `CfgID` = @CfgID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ResetTime", resetTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "resetTime">数据重置时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutResetTime(DateTime resetTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ResetTime` = @ResetTime";
			var parameter_ = Database.CreateInParameter("@ResetTime", resetTime, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutResetTimeAsync(DateTime resetTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ResetTime` = @ResetTime";
			var parameter_ = Database.CreateInParameter("@ResetTime", resetTime, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutResetTime
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string cfgID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(cfgID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string cfgID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(cfgID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string cfgID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `CfgID` = @CfgID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
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
		public bool Set(Src_push_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.CfgID) == null)
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
		public async Task<bool> SetAsync(Src_push_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.CfgID) == null)
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
		/// /// <param name = "cfgID">键Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Src_push_configEO GetByPK(string cfgID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(cfgID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		public async Task<Src_push_configEO> GetByPKAsync(string cfgID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(cfgID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		private void RepairGetByPKData(string cfgID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`CfgID` = @CfgID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`CfgID` = @CfgID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`CfgID` = @CfgID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryId`", "`CfgID` = @CfgID", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryId`", "`CfgID` = @CfgID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`CfgID` = @CfgID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`CfgID` = @CfgID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 GameTop（字段）
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetGameTopByPK(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`GameTop`", "`CfgID` = @CfgID", paras_, tm_);
		}
		public async Task<int?> GetGameTopByPKAsync(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`GameTop`", "`CfgID` = @CfgID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserTop（字段）
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetUserTopByPK(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`UserTop`", "`CfgID` = @CfgID", paras_, tm_);
		}
		public async Task<int?> GetUserTopByPKAsync(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`UserTop`", "`CfgID` = @CfgID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ResetTime（字段）
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetResetTimeByPK(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`ResetTime`", "`CfgID` = @CfgID", paras_, tm_);
		}
		public async Task<DateTime> GetResetTimeByPKAsync(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`ResetTime`", "`CfgID` = @CfgID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "cfgID">键Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`CfgID` = @CfgID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string cfgID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CfgID", cfgID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`CfgID` = @CfgID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Src_push_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Src_push_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Src_push_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Src_push_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		public async Task<List<Src_push_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByCountryIdAsync(string countryId, int top_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Src_push_configEO>> GetByCountryIdAsync(string countryId, string sort_)
		{
			return await GetByCountryIdAsync(countryId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryId != null ? "`CountryId` = @CountryId" : "`CountryId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryId != null)
				paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		public async Task<List<Src_push_configEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryId != null ? "`CountryId` = @CountryId" : "`CountryId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryId != null)
				paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Src_push_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Src_push_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Src_push_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Src_push_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		public async Task<List<Src_push_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByGameTop
		
		/// <summary>
		/// 按 GameTop（字段） 查询
		/// </summary>
		/// /// <param name = "gameTop">游戏净盈利/净亏损limit</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByGameTop(int? gameTop)
		{
			return GetByGameTop(gameTop, 0, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByGameTopAsync(int? gameTop)
		{
			return await GetByGameTopAsync(gameTop, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GameTop（字段） 查询
		/// </summary>
		/// /// <param name = "gameTop">游戏净盈利/净亏损limit</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByGameTop(int? gameTop, TransactionManager tm_)
		{
			return GetByGameTop(gameTop, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByGameTopAsync(int? gameTop, TransactionManager tm_)
		{
			return await GetByGameTopAsync(gameTop, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GameTop（字段） 查询
		/// </summary>
		/// /// <param name = "gameTop">游戏净盈利/净亏损limit</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByGameTop(int? gameTop, int top_)
		{
			return GetByGameTop(gameTop, top_, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByGameTopAsync(int? gameTop, int top_)
		{
			return await GetByGameTopAsync(gameTop, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GameTop（字段） 查询
		/// </summary>
		/// /// <param name = "gameTop">游戏净盈利/净亏损limit</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByGameTop(int? gameTop, int top_, TransactionManager tm_)
		{
			return GetByGameTop(gameTop, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByGameTopAsync(int? gameTop, int top_, TransactionManager tm_)
		{
			return await GetByGameTopAsync(gameTop, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GameTop（字段） 查询
		/// </summary>
		/// /// <param name = "gameTop">游戏净盈利/净亏损limit</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByGameTop(int? gameTop, string sort_)
		{
			return GetByGameTop(gameTop, 0, sort_, null);
		}
		public async Task<List<Src_push_configEO>> GetByGameTopAsync(int? gameTop, string sort_)
		{
			return await GetByGameTopAsync(gameTop, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 GameTop（字段） 查询
		/// </summary>
		/// /// <param name = "gameTop">游戏净盈利/净亏损limit</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByGameTop(int? gameTop, string sort_, TransactionManager tm_)
		{
			return GetByGameTop(gameTop, 0, sort_, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByGameTopAsync(int? gameTop, string sort_, TransactionManager tm_)
		{
			return await GetByGameTopAsync(gameTop, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 GameTop（字段） 查询
		/// </summary>
		/// /// <param name = "gameTop">游戏净盈利/净亏损limit</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByGameTop(int? gameTop, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(gameTop.HasValue ? "`GameTop` = @GameTop" : "`GameTop` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (gameTop.HasValue)
				paras_.Add(Database.CreateInParameter("@GameTop", gameTop.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		public async Task<List<Src_push_configEO>> GetByGameTopAsync(int? gameTop, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(gameTop.HasValue ? "`GameTop` = @GameTop" : "`GameTop` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (gameTop.HasValue)
				paras_.Add(Database.CreateInParameter("@GameTop", gameTop.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		#endregion // GetByGameTop
		#region GetByUserTop
		
		/// <summary>
		/// 按 UserTop（字段） 查询
		/// </summary>
		/// /// <param name = "userTop">用户净盈利/净亏损limit</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByUserTop(int? userTop)
		{
			return GetByUserTop(userTop, 0, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByUserTopAsync(int? userTop)
		{
			return await GetByUserTopAsync(userTop, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserTop（字段） 查询
		/// </summary>
		/// /// <param name = "userTop">用户净盈利/净亏损limit</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByUserTop(int? userTop, TransactionManager tm_)
		{
			return GetByUserTop(userTop, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByUserTopAsync(int? userTop, TransactionManager tm_)
		{
			return await GetByUserTopAsync(userTop, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserTop（字段） 查询
		/// </summary>
		/// /// <param name = "userTop">用户净盈利/净亏损limit</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByUserTop(int? userTop, int top_)
		{
			return GetByUserTop(userTop, top_, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByUserTopAsync(int? userTop, int top_)
		{
			return await GetByUserTopAsync(userTop, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserTop（字段） 查询
		/// </summary>
		/// /// <param name = "userTop">用户净盈利/净亏损limit</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByUserTop(int? userTop, int top_, TransactionManager tm_)
		{
			return GetByUserTop(userTop, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByUserTopAsync(int? userTop, int top_, TransactionManager tm_)
		{
			return await GetByUserTopAsync(userTop, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserTop（字段） 查询
		/// </summary>
		/// /// <param name = "userTop">用户净盈利/净亏损limit</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByUserTop(int? userTop, string sort_)
		{
			return GetByUserTop(userTop, 0, sort_, null);
		}
		public async Task<List<Src_push_configEO>> GetByUserTopAsync(int? userTop, string sort_)
		{
			return await GetByUserTopAsync(userTop, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserTop（字段） 查询
		/// </summary>
		/// /// <param name = "userTop">用户净盈利/净亏损limit</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByUserTop(int? userTop, string sort_, TransactionManager tm_)
		{
			return GetByUserTop(userTop, 0, sort_, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByUserTopAsync(int? userTop, string sort_, TransactionManager tm_)
		{
			return await GetByUserTopAsync(userTop, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserTop（字段） 查询
		/// </summary>
		/// /// <param name = "userTop">用户净盈利/净亏损limit</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByUserTop(int? userTop, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userTop.HasValue ? "`UserTop` = @UserTop" : "`UserTop` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userTop.HasValue)
				paras_.Add(Database.CreateInParameter("@UserTop", userTop.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		public async Task<List<Src_push_configEO>> GetByUserTopAsync(int? userTop, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userTop.HasValue ? "`UserTop` = @UserTop" : "`UserTop` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userTop.HasValue)
				paras_.Add(Database.CreateInParameter("@UserTop", userTop.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		#endregion // GetByUserTop
		#region GetByResetTime
		
		/// <summary>
		/// 按 ResetTime（字段） 查询
		/// </summary>
		/// /// <param name = "resetTime">数据重置时间</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByResetTime(DateTime resetTime)
		{
			return GetByResetTime(resetTime, 0, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByResetTimeAsync(DateTime resetTime)
		{
			return await GetByResetTimeAsync(resetTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ResetTime（字段） 查询
		/// </summary>
		/// /// <param name = "resetTime">数据重置时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByResetTime(DateTime resetTime, TransactionManager tm_)
		{
			return GetByResetTime(resetTime, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByResetTimeAsync(DateTime resetTime, TransactionManager tm_)
		{
			return await GetByResetTimeAsync(resetTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ResetTime（字段） 查询
		/// </summary>
		/// /// <param name = "resetTime">数据重置时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByResetTime(DateTime resetTime, int top_)
		{
			return GetByResetTime(resetTime, top_, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByResetTimeAsync(DateTime resetTime, int top_)
		{
			return await GetByResetTimeAsync(resetTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ResetTime（字段） 查询
		/// </summary>
		/// /// <param name = "resetTime">数据重置时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByResetTime(DateTime resetTime, int top_, TransactionManager tm_)
		{
			return GetByResetTime(resetTime, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByResetTimeAsync(DateTime resetTime, int top_, TransactionManager tm_)
		{
			return await GetByResetTimeAsync(resetTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ResetTime（字段） 查询
		/// </summary>
		/// /// <param name = "resetTime">数据重置时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByResetTime(DateTime resetTime, string sort_)
		{
			return GetByResetTime(resetTime, 0, sort_, null);
		}
		public async Task<List<Src_push_configEO>> GetByResetTimeAsync(DateTime resetTime, string sort_)
		{
			return await GetByResetTimeAsync(resetTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ResetTime（字段） 查询
		/// </summary>
		/// /// <param name = "resetTime">数据重置时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByResetTime(DateTime resetTime, string sort_, TransactionManager tm_)
		{
			return GetByResetTime(resetTime, 0, sort_, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByResetTimeAsync(DateTime resetTime, string sort_, TransactionManager tm_)
		{
			return await GetByResetTimeAsync(resetTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ResetTime（字段） 查询
		/// </summary>
		/// /// <param name = "resetTime">数据重置时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByResetTime(DateTime resetTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ResetTime` = @ResetTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ResetTime", resetTime, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		public async Task<List<Src_push_configEO>> GetByResetTimeAsync(DateTime resetTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ResetTime` = @ResetTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ResetTime", resetTime, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		#endregion // GetByResetTime
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Src_push_configEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Src_push_configEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_configEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Src_push_configEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Src_push_configEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Src_push_configEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Src_push_configEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		public async Task<List<Src_push_configEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_configEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
