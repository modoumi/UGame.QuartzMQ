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
	/// 推送消息表
	/// 【表 src_push_message 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Src_push_messageEO : IRowMapper<Src_push_messageEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Src_push_messageEO()
		{
			this.SummaryType = 0;
			this.ProfitAmount = 0;
			this.LossAmount = 0;
			this.SumProfit = 0;
			this.SumLoss = 0;
			this.RegisterUsers = 0;
			this.BetUsers = 0;
			this.OrderNum = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalMessageID;
		/// <summary>
		/// 【数据库中的原始主键 MessageID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalMessageID
		{
			get { return _originalMessageID; }
			set { HasOriginal = true; _originalMessageID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "MessageID", MessageID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 主键GUID
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string MessageID { get; set; }
		/// <summary>
		/// 汇总时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 2)]
		public DateTime SummaryTime { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 统计类型
		///              1、平台每20分钟净输赢
		///              2、app每20分钟净盈利top
		///              3、app每20分钟净亏损top
		///              4、每20分钟用户净盈利top
		///              5、每20分钟用户净亏损top
		///              6、每20分钟用户充值总额
		///              7、每20分钟用户提现总额
		///              8、平台每小时注册用户数量
		///              9、平台每小时用户下注数量
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int SummaryType { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 5)]
		public string CountryId { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 6)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 应用编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 7)]
		public string AppID { get; set; }
		/// <summary>
		/// 用户编码(GUID)
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 8)]
		public string UserID { get; set; }
		/// <summary>
		/// 净盈利
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long ProfitAmount { get; set; }
		/// <summary>
		/// 净亏损
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long LossAmount { get; set; }
		/// <summary>
		/// 总净盈利
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 11)]
		public long SumProfit { get; set; }
		/// <summary>
		/// 总净亏损
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 12)]
		public long SumLoss { get; set; }
		/// <summary>
		/// 每小时注册数量
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 13)]
		public int RegisterUsers { get; set; }
		/// <summary>
		/// 每小时下注用户数量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 14)]
		public long BetUsers { get; set; }
		/// <summary>
		/// 排序，从小到大
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 15)]
		public int OrderNum { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 16)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Src_push_messageEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Src_push_messageEO MapDataReader(IDataReader reader)
		{
		    Src_push_messageEO ret = new Src_push_messageEO();
			ret.MessageID = reader.ToString("MessageID");
			ret.OriginalMessageID = ret.MessageID;
			ret.SummaryTime = reader.ToDateTime("SummaryTime");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.SummaryType = reader.ToInt32("SummaryType");
			ret.CountryId = reader.ToString("CountryId");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.AppID = reader.ToString("AppID");
			ret.UserID = reader.ToString("UserID");
			ret.ProfitAmount = reader.ToInt64("ProfitAmount");
			ret.LossAmount = reader.ToInt64("LossAmount");
			ret.SumProfit = reader.ToInt64("SumProfit");
			ret.SumLoss = reader.ToInt64("SumLoss");
			ret.RegisterUsers = reader.ToInt32("RegisterUsers");
			ret.BetUsers = reader.ToInt64("BetUsers");
			ret.OrderNum = reader.ToInt32("OrderNum");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 推送消息表
	/// 【表 src_push_message 的操作类】
	/// </summary>
	[Obsolete]
	public class Src_push_messageMO : MySqlTableMO<Src_push_messageEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`src_push_message`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Src_push_messageMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Src_push_messageMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Src_push_messageMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Src_push_messageEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Src_push_messageEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Src_push_messageEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`MessageID`, `SummaryTime`, `OperatorID`, `SummaryType`, `CountryId`, `CurrencyID`, `AppID`, `UserID`, `ProfitAmount`, `LossAmount`, `SumProfit`, `SumLoss`, `RegisterUsers`, `BetUsers`, `OrderNum`, `RecDate`) VALUE (@MessageID, @SummaryTime, @OperatorID, @SummaryType, @CountryId, @CurrencyID, @AppID, @UserID, @ProfitAmount, @LossAmount, @SumProfit, @SumLoss, @RegisterUsers, @BetUsers, @OrderNum, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", item.MessageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@SummaryTime", item.SummaryTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@SummaryType", item.SummaryType, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryId", item.CountryId != null ? item.CountryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProfitAmount", item.ProfitAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@LossAmount", item.LossAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@SumProfit", item.SumProfit, MySqlDbType.Int64),
				Database.CreateInParameter("@SumLoss", item.SumLoss, MySqlDbType.Int64),
				Database.CreateInParameter("@RegisterUsers", item.RegisterUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@BetUsers", item.BetUsers, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Src_push_messageEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Src_push_messageEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Src_push_messageEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`MessageID`, `SummaryTime`, `OperatorID`, `SummaryType`, `CountryId`, `CurrencyID`, `AppID`, `UserID`, `ProfitAmount`, `LossAmount`, `SumProfit`, `SumLoss`, `RegisterUsers`, `BetUsers`, `OrderNum`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.MessageID}','{item.SummaryTime.ToString("yyyy-MM-dd HH:mm:ss")}','{item.OperatorID}',{item.SummaryType},'{item.CountryId}','{item.CurrencyID}','{item.AppID}','{item.UserID}',{item.ProfitAmount},{item.LossAmount},{item.SumProfit},{item.SumLoss},{item.RegisterUsers},{item.BetUsers},{item.OrderNum},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string messageID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(messageID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(messageID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string messageID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Src_push_messageEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.MessageID, tm_);
		}
		public async Task<int> RemoveAsync(Src_push_messageEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.MessageID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveBySummaryTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "summaryTime">汇总时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySummaryTime(DateTime summaryTime, TransactionManager tm_ = null)
		{
			RepairRemoveBySummaryTimeData(summaryTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySummaryTimeAsync(DateTime summaryTime, TransactionManager tm_ = null)
		{
			RepairRemoveBySummaryTimeData(summaryTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySummaryTimeData(DateTime summaryTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SummaryTime` = @SummaryTime";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SummaryTime", summaryTime, MySqlDbType.DateTime));
		}
		#endregion // RemoveBySummaryTime
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
		#region RemoveBySummaryType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "summaryType">统计类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySummaryType(int summaryType, TransactionManager tm_ = null)
		{
			RepairRemoveBySummaryTypeData(summaryType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySummaryTypeAsync(int summaryType, TransactionManager tm_ = null)
		{
			RepairRemoveBySummaryTypeData(summaryType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySummaryTypeData(int summaryType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SummaryType` = @SummaryType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SummaryType", summaryType, MySqlDbType.Int32));
		}
		#endregion // RemoveBySummaryType
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
			sql_ = $"DELETE FROM {TableName} WHERE " + (appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAppID
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserID(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserIDData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserID
		#region RemoveByProfitAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "profitAmount">净盈利</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProfitAmount(long profitAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByProfitAmountData(profitAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProfitAmountAsync(long profitAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByProfitAmountData(profitAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProfitAmountData(long profitAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ProfitAmount` = @ProfitAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ProfitAmount", profitAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByProfitAmount
		#region RemoveByLossAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lossAmount">净亏损</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLossAmount(long lossAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByLossAmountData(lossAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLossAmountAsync(long lossAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByLossAmountData(lossAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLossAmountData(long lossAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LossAmount` = @LossAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LossAmount", lossAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByLossAmount
		#region RemoveBySumProfit
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sumProfit">总净盈利</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySumProfit(long sumProfit, TransactionManager tm_ = null)
		{
			RepairRemoveBySumProfitData(sumProfit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySumProfitAsync(long sumProfit, TransactionManager tm_ = null)
		{
			RepairRemoveBySumProfitData(sumProfit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySumProfitData(long sumProfit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SumProfit` = @SumProfit";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumProfit", sumProfit, MySqlDbType.Int64));
		}
		#endregion // RemoveBySumProfit
		#region RemoveBySumLoss
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sumLoss">总净亏损</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySumLoss(long sumLoss, TransactionManager tm_ = null)
		{
			RepairRemoveBySumLossData(sumLoss, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySumLossAsync(long sumLoss, TransactionManager tm_ = null)
		{
			RepairRemoveBySumLossData(sumLoss, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySumLossData(long sumLoss, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SumLoss` = @SumLoss";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumLoss", sumLoss, MySqlDbType.Int64));
		}
		#endregion // RemoveBySumLoss
		#region RemoveByRegisterUsers
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "registerUsers">每小时注册数量</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRegisterUsers(int registerUsers, TransactionManager tm_ = null)
		{
			RepairRemoveByRegisterUsersData(registerUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRegisterUsersAsync(int registerUsers, TransactionManager tm_ = null)
		{
			RepairRemoveByRegisterUsersData(registerUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRegisterUsersData(int registerUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RegisterUsers` = @RegisterUsers";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RegisterUsers", registerUsers, MySqlDbType.Int32));
		}
		#endregion // RemoveByRegisterUsers
		#region RemoveByBetUsers
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betUsers">每小时下注用户数量</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetUsers(long betUsers, TransactionManager tm_ = null)
		{
			RepairRemoveByBetUsersData(betUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetUsersAsync(long betUsers, TransactionManager tm_ = null)
		{
			RepairRemoveByBetUsersData(betUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetUsersData(long betUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetUsers` = @BetUsers";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetUsers
		#region RemoveByOrderNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderNum(int orderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderNumData(orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderNumAsync(int orderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderNumData(orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderNumData(int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OrderNum` = @OrderNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByOrderNum
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
		public int Put(Src_push_messageEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Src_push_messageEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Src_push_messageEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MessageID` = @MessageID, `SummaryTime` = @SummaryTime, `OperatorID` = @OperatorID, `SummaryType` = @SummaryType, `CountryId` = @CountryId, `CurrencyID` = @CurrencyID, `AppID` = @AppID, `UserID` = @UserID, `ProfitAmount` = @ProfitAmount, `LossAmount` = @LossAmount, `SumProfit` = @SumProfit, `SumLoss` = @SumLoss, `RegisterUsers` = @RegisterUsers, `BetUsers` = @BetUsers, `OrderNum` = @OrderNum WHERE `MessageID` = @MessageID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", item.MessageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@SummaryTime", item.SummaryTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@SummaryType", item.SummaryType, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryId", item.CountryId != null ? item.CountryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProfitAmount", item.ProfitAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@LossAmount", item.LossAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@SumProfit", item.SumProfit, MySqlDbType.Int64),
				Database.CreateInParameter("@SumLoss", item.SumLoss, MySqlDbType.Int64),
				Database.CreateInParameter("@RegisterUsers", item.RegisterUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@BetUsers", item.BetUsers, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID_Original", item.HasOriginal ? item.OriginalMessageID : item.MessageID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Src_push_messageEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Src_push_messageEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string messageID, string set_, params object[] values_)
		{
			return Put(set_, "`MessageID` = @MessageID", ConcatValues(values_, messageID));
		}
		public async Task<int> PutByPKAsync(string messageID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`MessageID` = @MessageID", ConcatValues(values_, messageID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string messageID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`MessageID` = @MessageID", tm_, ConcatValues(values_, messageID));
		}
		public async Task<int> PutByPKAsync(string messageID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`MessageID` = @MessageID", tm_, ConcatValues(values_, messageID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string messageID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`MessageID` = @MessageID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string messageID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`MessageID` = @MessageID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutSummaryTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "summaryTime">汇总时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSummaryTimeByPK(string messageID, DateTime summaryTime, TransactionManager tm_ = null)
		{
			RepairPutSummaryTimeByPKData(messageID, summaryTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSummaryTimeByPKAsync(string messageID, DateTime summaryTime, TransactionManager tm_ = null)
		{
			RepairPutSummaryTimeByPKData(messageID, summaryTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSummaryTimeByPKData(string messageID, DateTime summaryTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SummaryTime` = @SummaryTime  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SummaryTime", summaryTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "summaryTime">汇总时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSummaryTime(DateTime summaryTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SummaryTime` = @SummaryTime";
			var parameter_ = Database.CreateInParameter("@SummaryTime", summaryTime, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSummaryTimeAsync(DateTime summaryTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SummaryTime` = @SummaryTime";
			var parameter_ = Database.CreateInParameter("@SummaryTime", summaryTime, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSummaryTime
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string messageID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(messageID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string messageID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(messageID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string messageID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
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
		#region PutSummaryType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "summaryType">统计类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSummaryTypeByPK(string messageID, int summaryType, TransactionManager tm_ = null)
		{
			RepairPutSummaryTypeByPKData(messageID, summaryType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSummaryTypeByPKAsync(string messageID, int summaryType, TransactionManager tm_ = null)
		{
			RepairPutSummaryTypeByPKData(messageID, summaryType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSummaryTypeByPKData(string messageID, int summaryType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SummaryType` = @SummaryType  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SummaryType", summaryType, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "summaryType">统计类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSummaryType(int summaryType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SummaryType` = @SummaryType";
			var parameter_ = Database.CreateInParameter("@SummaryType", summaryType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSummaryTypeAsync(int summaryType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SummaryType` = @SummaryType";
			var parameter_ = Database.CreateInParameter("@SummaryType", summaryType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSummaryType
		#region PutCountryId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIdByPK(string messageID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(messageID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIdByPKAsync(string messageID, string countryId, TransactionManager tm_ = null)
		{
			RepairPutCountryIdByPKData(messageID, countryId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIdByPKData(string messageID, string countryId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryId` = @CountryId  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryId", countryId != null ? countryId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
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
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string messageID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(messageID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string messageID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(messageID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string messageID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
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
		#region PutAppID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppIDByPK(string messageID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(messageID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppIDByPKAsync(string messageID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(messageID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppIDByPKData(string messageID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppID(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppID
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIDByPK(string messageID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(messageID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIDByPKAsync(string messageID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(messageID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIDByPKData(string messageID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserID(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserID
		#region PutProfitAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "profitAmount">净盈利</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProfitAmountByPK(string messageID, long profitAmount, TransactionManager tm_ = null)
		{
			RepairPutProfitAmountByPKData(messageID, profitAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProfitAmountByPKAsync(string messageID, long profitAmount, TransactionManager tm_ = null)
		{
			RepairPutProfitAmountByPKData(messageID, profitAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProfitAmountByPKData(string messageID, long profitAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProfitAmount` = @ProfitAmount  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProfitAmount", profitAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "profitAmount">净盈利</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProfitAmount(long profitAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProfitAmount` = @ProfitAmount";
			var parameter_ = Database.CreateInParameter("@ProfitAmount", profitAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProfitAmountAsync(long profitAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProfitAmount` = @ProfitAmount";
			var parameter_ = Database.CreateInParameter("@ProfitAmount", profitAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProfitAmount
		#region PutLossAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "lossAmount">净亏损</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLossAmountByPK(string messageID, long lossAmount, TransactionManager tm_ = null)
		{
			RepairPutLossAmountByPKData(messageID, lossAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLossAmountByPKAsync(string messageID, long lossAmount, TransactionManager tm_ = null)
		{
			RepairPutLossAmountByPKData(messageID, lossAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLossAmountByPKData(string messageID, long lossAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LossAmount` = @LossAmount  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LossAmount", lossAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lossAmount">净亏损</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLossAmount(long lossAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LossAmount` = @LossAmount";
			var parameter_ = Database.CreateInParameter("@LossAmount", lossAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLossAmountAsync(long lossAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LossAmount` = @LossAmount";
			var parameter_ = Database.CreateInParameter("@LossAmount", lossAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLossAmount
		#region PutSumProfit
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "sumProfit">总净盈利</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumProfitByPK(string messageID, long sumProfit, TransactionManager tm_ = null)
		{
			RepairPutSumProfitByPKData(messageID, sumProfit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSumProfitByPKAsync(string messageID, long sumProfit, TransactionManager tm_ = null)
		{
			RepairPutSumProfitByPKData(messageID, sumProfit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSumProfitByPKData(string messageID, long sumProfit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SumProfit` = @SumProfit  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumProfit", sumProfit, MySqlDbType.Int64),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sumProfit">总净盈利</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumProfit(long sumProfit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumProfit` = @SumProfit";
			var parameter_ = Database.CreateInParameter("@SumProfit", sumProfit, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSumProfitAsync(long sumProfit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumProfit` = @SumProfit";
			var parameter_ = Database.CreateInParameter("@SumProfit", sumProfit, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSumProfit
		#region PutSumLoss
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "sumLoss">总净亏损</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumLossByPK(string messageID, long sumLoss, TransactionManager tm_ = null)
		{
			RepairPutSumLossByPKData(messageID, sumLoss, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSumLossByPKAsync(string messageID, long sumLoss, TransactionManager tm_ = null)
		{
			RepairPutSumLossByPKData(messageID, sumLoss, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSumLossByPKData(string messageID, long sumLoss, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SumLoss` = @SumLoss  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SumLoss", sumLoss, MySqlDbType.Int64),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sumLoss">总净亏损</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSumLoss(long sumLoss, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumLoss` = @SumLoss";
			var parameter_ = Database.CreateInParameter("@SumLoss", sumLoss, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSumLossAsync(long sumLoss, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SumLoss` = @SumLoss";
			var parameter_ = Database.CreateInParameter("@SumLoss", sumLoss, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSumLoss
		#region PutRegisterUsers
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "registerUsers">每小时注册数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegisterUsersByPK(string messageID, int registerUsers, TransactionManager tm_ = null)
		{
			RepairPutRegisterUsersByPKData(messageID, registerUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRegisterUsersByPKAsync(string messageID, int registerUsers, TransactionManager tm_ = null)
		{
			RepairPutRegisterUsersByPKData(messageID, registerUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRegisterUsersByPKData(string messageID, int registerUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RegisterUsers` = @RegisterUsers  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RegisterUsers", registerUsers, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "registerUsers">每小时注册数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegisterUsers(int registerUsers, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RegisterUsers` = @RegisterUsers";
			var parameter_ = Database.CreateInParameter("@RegisterUsers", registerUsers, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRegisterUsersAsync(int registerUsers, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RegisterUsers` = @RegisterUsers";
			var parameter_ = Database.CreateInParameter("@RegisterUsers", registerUsers, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRegisterUsers
		#region PutBetUsers
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "betUsers">每小时下注用户数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetUsersByPK(string messageID, long betUsers, TransactionManager tm_ = null)
		{
			RepairPutBetUsersByPKData(messageID, betUsers, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetUsersByPKAsync(string messageID, long betUsers, TransactionManager tm_ = null)
		{
			RepairPutBetUsersByPKData(messageID, betUsers, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetUsersByPKData(string messageID, long betUsers, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetUsers` = @BetUsers  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int64),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betUsers">每小时下注用户数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetUsers(long betUsers, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetUsers` = @BetUsers";
			var parameter_ = Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetUsersAsync(long betUsers, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetUsers` = @BetUsers";
			var parameter_ = Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetUsers
		#region PutOrderNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNumByPK(string messageID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(messageID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderNumByPKAsync(string messageID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(messageID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderNumByPKData(string messageID, int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNum(int orderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum";
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderNumAsync(int orderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum";
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderNum
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string messageID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(messageID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string messageID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(messageID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string messageID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
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
		public bool Set(Src_push_messageEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.MessageID) == null)
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
		public async Task<bool> SetAsync(Src_push_messageEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.MessageID) == null)
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
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Src_push_messageEO GetByPK(string messageID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(messageID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<Src_push_messageEO> GetByPKAsync(string messageID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(messageID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		private void RepairGetByPKData(string messageID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`MessageID` = @MessageID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 SummaryTime（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetSummaryTimeByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`SummaryTime`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<DateTime> GetSummaryTimeByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`SummaryTime`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SummaryType（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSummaryTypeByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`SummaryType`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<int> GetSummaryTypeByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`SummaryType`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryId（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIdByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryId`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetCountryIdByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryId`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProfitAmount（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetProfitAmountByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`ProfitAmount`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<long> GetProfitAmountByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`ProfitAmount`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LossAmount（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetLossAmountByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`LossAmount`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<long> GetLossAmountByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`LossAmount`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SumProfit（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetSumProfitByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`SumProfit`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<long> GetSumProfitByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`SumProfit`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SumLoss（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetSumLossByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`SumLoss`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<long> GetSumLossByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`SumLoss`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RegisterUsers（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetRegisterUsersByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`RegisterUsers`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<int> GetRegisterUsersByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`RegisterUsers`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetUsers（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetUsersByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetUsers`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<long> GetBetUsersByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetUsers`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderNum（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOrderNumByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OrderNum`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<int> GetOrderNumByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OrderNum`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "messageID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`MessageID` = @MessageID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetBySummaryTime
		
		/// <summary>
		/// 按 SummaryTime（字段） 查询
		/// </summary>
		/// /// <param name = "summaryTime">汇总时间</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryTime(DateTime summaryTime)
		{
			return GetBySummaryTime(summaryTime, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTimeAsync(DateTime summaryTime)
		{
			return await GetBySummaryTimeAsync(summaryTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SummaryTime（字段） 查询
		/// </summary>
		/// /// <param name = "summaryTime">汇总时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryTime(DateTime summaryTime, TransactionManager tm_)
		{
			return GetBySummaryTime(summaryTime, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTimeAsync(DateTime summaryTime, TransactionManager tm_)
		{
			return await GetBySummaryTimeAsync(summaryTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SummaryTime（字段） 查询
		/// </summary>
		/// /// <param name = "summaryTime">汇总时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryTime(DateTime summaryTime, int top_)
		{
			return GetBySummaryTime(summaryTime, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTimeAsync(DateTime summaryTime, int top_)
		{
			return await GetBySummaryTimeAsync(summaryTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SummaryTime（字段） 查询
		/// </summary>
		/// /// <param name = "summaryTime">汇总时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryTime(DateTime summaryTime, int top_, TransactionManager tm_)
		{
			return GetBySummaryTime(summaryTime, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTimeAsync(DateTime summaryTime, int top_, TransactionManager tm_)
		{
			return await GetBySummaryTimeAsync(summaryTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SummaryTime（字段） 查询
		/// </summary>
		/// /// <param name = "summaryTime">汇总时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryTime(DateTime summaryTime, string sort_)
		{
			return GetBySummaryTime(summaryTime, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTimeAsync(DateTime summaryTime, string sort_)
		{
			return await GetBySummaryTimeAsync(summaryTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SummaryTime（字段） 查询
		/// </summary>
		/// /// <param name = "summaryTime">汇总时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryTime(DateTime summaryTime, string sort_, TransactionManager tm_)
		{
			return GetBySummaryTime(summaryTime, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTimeAsync(DateTime summaryTime, string sort_, TransactionManager tm_)
		{
			return await GetBySummaryTimeAsync(summaryTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SummaryTime（字段） 查询
		/// </summary>
		/// /// <param name = "summaryTime">汇总时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryTime(DateTime summaryTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SummaryTime` = @SummaryTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SummaryTime", summaryTime, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTimeAsync(DateTime summaryTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SummaryTime` = @SummaryTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SummaryTime", summaryTime, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetBySummaryTime
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Src_push_messageEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Src_push_messageEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Src_push_messageEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetBySummaryType
		
		/// <summary>
		/// 按 SummaryType（字段） 查询
		/// </summary>
		/// /// <param name = "summaryType">统计类型</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryType(int summaryType)
		{
			return GetBySummaryType(summaryType, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTypeAsync(int summaryType)
		{
			return await GetBySummaryTypeAsync(summaryType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SummaryType（字段） 查询
		/// </summary>
		/// /// <param name = "summaryType">统计类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryType(int summaryType, TransactionManager tm_)
		{
			return GetBySummaryType(summaryType, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTypeAsync(int summaryType, TransactionManager tm_)
		{
			return await GetBySummaryTypeAsync(summaryType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SummaryType（字段） 查询
		/// </summary>
		/// /// <param name = "summaryType">统计类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryType(int summaryType, int top_)
		{
			return GetBySummaryType(summaryType, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTypeAsync(int summaryType, int top_)
		{
			return await GetBySummaryTypeAsync(summaryType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SummaryType（字段） 查询
		/// </summary>
		/// /// <param name = "summaryType">统计类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryType(int summaryType, int top_, TransactionManager tm_)
		{
			return GetBySummaryType(summaryType, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTypeAsync(int summaryType, int top_, TransactionManager tm_)
		{
			return await GetBySummaryTypeAsync(summaryType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SummaryType（字段） 查询
		/// </summary>
		/// /// <param name = "summaryType">统计类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryType(int summaryType, string sort_)
		{
			return GetBySummaryType(summaryType, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTypeAsync(int summaryType, string sort_)
		{
			return await GetBySummaryTypeAsync(summaryType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SummaryType（字段） 查询
		/// </summary>
		/// /// <param name = "summaryType">统计类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryType(int summaryType, string sort_, TransactionManager tm_)
		{
			return GetBySummaryType(summaryType, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTypeAsync(int summaryType, string sort_, TransactionManager tm_)
		{
			return await GetBySummaryTypeAsync(summaryType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SummaryType（字段） 查询
		/// </summary>
		/// /// <param name = "summaryType">统计类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySummaryType(int summaryType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SummaryType` = @SummaryType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SummaryType", summaryType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetBySummaryTypeAsync(int summaryType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SummaryType` = @SummaryType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SummaryType", summaryType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetBySummaryType
		#region GetByCountryId
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByCountryId(string countryId)
		{
			return GetByCountryId(countryId, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByCountryIdAsync(string countryId)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByCountryId(string countryId, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByCountryIdAsync(string countryId, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByCountryId(string countryId, int top_)
		{
			return GetByCountryId(countryId, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByCountryIdAsync(string countryId, int top_)
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
		public List<Src_push_messageEO> GetByCountryId(string countryId, int top_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByCountryIdAsync(string countryId, int top_, TransactionManager tm_)
		{
			return await GetByCountryIdAsync(countryId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryId（字段） 查询
		/// </summary>
		/// /// <param name = "countryId">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByCountryId(string countryId, string sort_)
		{
			return GetByCountryId(countryId, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetByCountryIdAsync(string countryId, string sort_)
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
		public List<Src_push_messageEO> GetByCountryId(string countryId, string sort_, TransactionManager tm_)
		{
			return GetByCountryId(countryId, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByCountryIdAsync(string countryId, string sort_, TransactionManager tm_)
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
		public List<Src_push_messageEO> GetByCountryId(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryId != null ? "`CountryId` = @CountryId" : "`CountryId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryId != null)
				paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetByCountryIdAsync(string countryId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryId != null ? "`CountryId` = @CountryId" : "`CountryId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryId != null)
				paras_.Add(Database.CreateInParameter("@CountryId", countryId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetByCountryId
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Src_push_messageEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Src_push_messageEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Src_push_messageEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<Src_push_messageEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<Src_push_messageEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<Src_push_messageEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByProfitAmount
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">净盈利</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByProfitAmount(long profitAmount)
		{
			return GetByProfitAmount(profitAmount, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByProfitAmountAsync(long profitAmount)
		{
			return await GetByProfitAmountAsync(profitAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">净盈利</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByProfitAmount(long profitAmount, TransactionManager tm_)
		{
			return GetByProfitAmount(profitAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByProfitAmountAsync(long profitAmount, TransactionManager tm_)
		{
			return await GetByProfitAmountAsync(profitAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">净盈利</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByProfitAmount(long profitAmount, int top_)
		{
			return GetByProfitAmount(profitAmount, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByProfitAmountAsync(long profitAmount, int top_)
		{
			return await GetByProfitAmountAsync(profitAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">净盈利</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByProfitAmount(long profitAmount, int top_, TransactionManager tm_)
		{
			return GetByProfitAmount(profitAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByProfitAmountAsync(long profitAmount, int top_, TransactionManager tm_)
		{
			return await GetByProfitAmountAsync(profitAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">净盈利</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByProfitAmount(long profitAmount, string sort_)
		{
			return GetByProfitAmount(profitAmount, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetByProfitAmountAsync(long profitAmount, string sort_)
		{
			return await GetByProfitAmountAsync(profitAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">净盈利</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByProfitAmount(long profitAmount, string sort_, TransactionManager tm_)
		{
			return GetByProfitAmount(profitAmount, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByProfitAmountAsync(long profitAmount, string sort_, TransactionManager tm_)
		{
			return await GetByProfitAmountAsync(profitAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProfitAmount（字段） 查询
		/// </summary>
		/// /// <param name = "profitAmount">净盈利</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByProfitAmount(long profitAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ProfitAmount` = @ProfitAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ProfitAmount", profitAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetByProfitAmountAsync(long profitAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ProfitAmount` = @ProfitAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ProfitAmount", profitAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetByProfitAmount
		#region GetByLossAmount
		
		/// <summary>
		/// 按 LossAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lossAmount">净亏损</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByLossAmount(long lossAmount)
		{
			return GetByLossAmount(lossAmount, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByLossAmountAsync(long lossAmount)
		{
			return await GetByLossAmountAsync(lossAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LossAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lossAmount">净亏损</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByLossAmount(long lossAmount, TransactionManager tm_)
		{
			return GetByLossAmount(lossAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByLossAmountAsync(long lossAmount, TransactionManager tm_)
		{
			return await GetByLossAmountAsync(lossAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LossAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lossAmount">净亏损</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByLossAmount(long lossAmount, int top_)
		{
			return GetByLossAmount(lossAmount, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByLossAmountAsync(long lossAmount, int top_)
		{
			return await GetByLossAmountAsync(lossAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LossAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lossAmount">净亏损</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByLossAmount(long lossAmount, int top_, TransactionManager tm_)
		{
			return GetByLossAmount(lossAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByLossAmountAsync(long lossAmount, int top_, TransactionManager tm_)
		{
			return await GetByLossAmountAsync(lossAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LossAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lossAmount">净亏损</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByLossAmount(long lossAmount, string sort_)
		{
			return GetByLossAmount(lossAmount, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetByLossAmountAsync(long lossAmount, string sort_)
		{
			return await GetByLossAmountAsync(lossAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LossAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lossAmount">净亏损</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByLossAmount(long lossAmount, string sort_, TransactionManager tm_)
		{
			return GetByLossAmount(lossAmount, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByLossAmountAsync(long lossAmount, string sort_, TransactionManager tm_)
		{
			return await GetByLossAmountAsync(lossAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LossAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lossAmount">净亏损</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByLossAmount(long lossAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LossAmount` = @LossAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LossAmount", lossAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetByLossAmountAsync(long lossAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LossAmount` = @LossAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LossAmount", lossAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetByLossAmount
		#region GetBySumProfit
		
		/// <summary>
		/// 按 SumProfit（字段） 查询
		/// </summary>
		/// /// <param name = "sumProfit">总净盈利</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumProfit(long sumProfit)
		{
			return GetBySumProfit(sumProfit, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetBySumProfitAsync(long sumProfit)
		{
			return await GetBySumProfitAsync(sumProfit, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumProfit（字段） 查询
		/// </summary>
		/// /// <param name = "sumProfit">总净盈利</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumProfit(long sumProfit, TransactionManager tm_)
		{
			return GetBySumProfit(sumProfit, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetBySumProfitAsync(long sumProfit, TransactionManager tm_)
		{
			return await GetBySumProfitAsync(sumProfit, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumProfit（字段） 查询
		/// </summary>
		/// /// <param name = "sumProfit">总净盈利</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumProfit(long sumProfit, int top_)
		{
			return GetBySumProfit(sumProfit, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetBySumProfitAsync(long sumProfit, int top_)
		{
			return await GetBySumProfitAsync(sumProfit, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumProfit（字段） 查询
		/// </summary>
		/// /// <param name = "sumProfit">总净盈利</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumProfit(long sumProfit, int top_, TransactionManager tm_)
		{
			return GetBySumProfit(sumProfit, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetBySumProfitAsync(long sumProfit, int top_, TransactionManager tm_)
		{
			return await GetBySumProfitAsync(sumProfit, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumProfit（字段） 查询
		/// </summary>
		/// /// <param name = "sumProfit">总净盈利</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumProfit(long sumProfit, string sort_)
		{
			return GetBySumProfit(sumProfit, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetBySumProfitAsync(long sumProfit, string sort_)
		{
			return await GetBySumProfitAsync(sumProfit, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SumProfit（字段） 查询
		/// </summary>
		/// /// <param name = "sumProfit">总净盈利</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumProfit(long sumProfit, string sort_, TransactionManager tm_)
		{
			return GetBySumProfit(sumProfit, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetBySumProfitAsync(long sumProfit, string sort_, TransactionManager tm_)
		{
			return await GetBySumProfitAsync(sumProfit, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SumProfit（字段） 查询
		/// </summary>
		/// /// <param name = "sumProfit">总净盈利</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumProfit(long sumProfit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumProfit` = @SumProfit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumProfit", sumProfit, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetBySumProfitAsync(long sumProfit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumProfit` = @SumProfit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumProfit", sumProfit, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetBySumProfit
		#region GetBySumLoss
		
		/// <summary>
		/// 按 SumLoss（字段） 查询
		/// </summary>
		/// /// <param name = "sumLoss">总净亏损</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumLoss(long sumLoss)
		{
			return GetBySumLoss(sumLoss, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetBySumLossAsync(long sumLoss)
		{
			return await GetBySumLossAsync(sumLoss, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumLoss（字段） 查询
		/// </summary>
		/// /// <param name = "sumLoss">总净亏损</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumLoss(long sumLoss, TransactionManager tm_)
		{
			return GetBySumLoss(sumLoss, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetBySumLossAsync(long sumLoss, TransactionManager tm_)
		{
			return await GetBySumLossAsync(sumLoss, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumLoss（字段） 查询
		/// </summary>
		/// /// <param name = "sumLoss">总净亏损</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumLoss(long sumLoss, int top_)
		{
			return GetBySumLoss(sumLoss, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetBySumLossAsync(long sumLoss, int top_)
		{
			return await GetBySumLossAsync(sumLoss, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SumLoss（字段） 查询
		/// </summary>
		/// /// <param name = "sumLoss">总净亏损</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumLoss(long sumLoss, int top_, TransactionManager tm_)
		{
			return GetBySumLoss(sumLoss, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetBySumLossAsync(long sumLoss, int top_, TransactionManager tm_)
		{
			return await GetBySumLossAsync(sumLoss, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SumLoss（字段） 查询
		/// </summary>
		/// /// <param name = "sumLoss">总净亏损</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumLoss(long sumLoss, string sort_)
		{
			return GetBySumLoss(sumLoss, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetBySumLossAsync(long sumLoss, string sort_)
		{
			return await GetBySumLossAsync(sumLoss, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SumLoss（字段） 查询
		/// </summary>
		/// /// <param name = "sumLoss">总净亏损</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumLoss(long sumLoss, string sort_, TransactionManager tm_)
		{
			return GetBySumLoss(sumLoss, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetBySumLossAsync(long sumLoss, string sort_, TransactionManager tm_)
		{
			return await GetBySumLossAsync(sumLoss, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SumLoss（字段） 查询
		/// </summary>
		/// /// <param name = "sumLoss">总净亏损</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetBySumLoss(long sumLoss, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumLoss` = @SumLoss", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumLoss", sumLoss, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetBySumLossAsync(long sumLoss, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SumLoss` = @SumLoss", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SumLoss", sumLoss, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetBySumLoss
		#region GetByRegisterUsers
		
		/// <summary>
		/// 按 RegisterUsers（字段） 查询
		/// </summary>
		/// /// <param name = "registerUsers">每小时注册数量</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByRegisterUsers(int registerUsers)
		{
			return GetByRegisterUsers(registerUsers, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByRegisterUsersAsync(int registerUsers)
		{
			return await GetByRegisterUsersAsync(registerUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegisterUsers（字段） 查询
		/// </summary>
		/// /// <param name = "registerUsers">每小时注册数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByRegisterUsers(int registerUsers, TransactionManager tm_)
		{
			return GetByRegisterUsers(registerUsers, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByRegisterUsersAsync(int registerUsers, TransactionManager tm_)
		{
			return await GetByRegisterUsersAsync(registerUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegisterUsers（字段） 查询
		/// </summary>
		/// /// <param name = "registerUsers">每小时注册数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByRegisterUsers(int registerUsers, int top_)
		{
			return GetByRegisterUsers(registerUsers, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByRegisterUsersAsync(int registerUsers, int top_)
		{
			return await GetByRegisterUsersAsync(registerUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegisterUsers（字段） 查询
		/// </summary>
		/// /// <param name = "registerUsers">每小时注册数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByRegisterUsers(int registerUsers, int top_, TransactionManager tm_)
		{
			return GetByRegisterUsers(registerUsers, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByRegisterUsersAsync(int registerUsers, int top_, TransactionManager tm_)
		{
			return await GetByRegisterUsersAsync(registerUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegisterUsers（字段） 查询
		/// </summary>
		/// /// <param name = "registerUsers">每小时注册数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByRegisterUsers(int registerUsers, string sort_)
		{
			return GetByRegisterUsers(registerUsers, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetByRegisterUsersAsync(int registerUsers, string sort_)
		{
			return await GetByRegisterUsersAsync(registerUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegisterUsers（字段） 查询
		/// </summary>
		/// /// <param name = "registerUsers">每小时注册数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByRegisterUsers(int registerUsers, string sort_, TransactionManager tm_)
		{
			return GetByRegisterUsers(registerUsers, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByRegisterUsersAsync(int registerUsers, string sort_, TransactionManager tm_)
		{
			return await GetByRegisterUsersAsync(registerUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegisterUsers（字段） 查询
		/// </summary>
		/// /// <param name = "registerUsers">每小时注册数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByRegisterUsers(int registerUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegisterUsers` = @RegisterUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RegisterUsers", registerUsers, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetByRegisterUsersAsync(int registerUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RegisterUsers` = @RegisterUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RegisterUsers", registerUsers, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetByRegisterUsers
		#region GetByBetUsers
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">每小时下注用户数量</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByBetUsers(long betUsers)
		{
			return GetByBetUsers(betUsers, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByBetUsersAsync(long betUsers)
		{
			return await GetByBetUsersAsync(betUsers, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">每小时下注用户数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByBetUsers(long betUsers, TransactionManager tm_)
		{
			return GetByBetUsers(betUsers, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByBetUsersAsync(long betUsers, TransactionManager tm_)
		{
			return await GetByBetUsersAsync(betUsers, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">每小时下注用户数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByBetUsers(long betUsers, int top_)
		{
			return GetByBetUsers(betUsers, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByBetUsersAsync(long betUsers, int top_)
		{
			return await GetByBetUsersAsync(betUsers, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">每小时下注用户数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByBetUsers(long betUsers, int top_, TransactionManager tm_)
		{
			return GetByBetUsers(betUsers, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByBetUsersAsync(long betUsers, int top_, TransactionManager tm_)
		{
			return await GetByBetUsersAsync(betUsers, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">每小时下注用户数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByBetUsers(long betUsers, string sort_)
		{
			return GetByBetUsers(betUsers, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetByBetUsersAsync(long betUsers, string sort_)
		{
			return await GetByBetUsersAsync(betUsers, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">每小时下注用户数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByBetUsers(long betUsers, string sort_, TransactionManager tm_)
		{
			return GetByBetUsers(betUsers, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByBetUsersAsync(long betUsers, string sort_, TransactionManager tm_)
		{
			return await GetByBetUsersAsync(betUsers, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetUsers（字段） 查询
		/// </summary>
		/// /// <param name = "betUsers">每小时下注用户数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByBetUsers(long betUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetUsers` = @BetUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetByBetUsersAsync(long betUsers, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetUsers` = @BetUsers", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetUsers", betUsers, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetByBetUsers
		#region GetByOrderNum
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByOrderNum(int orderNum)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByOrderNumAsync(int orderNum)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByOrderNum(int orderNum, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByOrderNumAsync(int orderNum, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByOrderNum(int orderNum, int top_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByOrderNumAsync(int orderNum, int top_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByOrderNum(int orderNum, int top_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByOrderNumAsync(int orderNum, int top_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByOrderNum(int orderNum, string sort_)
		{
			return GetByOrderNum(orderNum, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetByOrderNumAsync(int orderNum, string sort_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByOrderNum(int orderNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByOrderNumAsync(int orderNum, string sort_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序，从小到大</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByOrderNum(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetByOrderNumAsync(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetByOrderNum
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Src_push_messageEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Src_push_messageEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Src_push_messageEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Src_push_messageEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Src_push_messageEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Src_push_messageEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Src_push_messageEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		public async Task<List<Src_push_messageEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Src_push_messageEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
