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
	/// 输返活动用户领取详情表
	/// 【表 sa_losecashback_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sa_losecashback_detailEO : IRowMapper<Sa_losecashback_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sa_losecashback_detailEO()
		{
			this.RefundAmount = 0;
			this.NotifyStatus = 0;
			this.ReceiveStatus = 0;
			this.FlowMultip = 1.00f;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalDetailID;
		/// <summary>
		/// 【数据库中的原始主键 DetailID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalDetailID
		{
			get { return _originalDetailID; }
			set { HasOriginal = true; _originalDetailID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DetailID", DetailID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 主键
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string DetailID { get; set; }
		/// <summary>
		/// 用户编码(GUID)
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 输返的日期
		/// 【字段 date】
		/// </summary>
		[DataMember(Order = 3)]
		public DateTime DayID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 5)]
		public string CountryID { get; set; }
		/// <summary>
		/// 货币类型（货币缩写RMB,USD）
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 6)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 输返的奖励金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long RefundAmount { get; set; }
		/// <summary>
		/// 发送通知状态，0-未通知1-已通知
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int NotifyStatus { get; set; }
		/// <summary>
		/// 用户领取状态，0-未领取1-已领取
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int ReceiveStatus { get; set; }
		/// <summary>
		/// 赠金提现所需要的流水倍数
		/// 【字段 float(10,2)】
		/// </summary>
		[DataMember(Order = 10)]
		public float FlowMultip { get; set; }
		/// <summary>
		/// 记录创建时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 11)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sa_losecashback_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sa_losecashback_detailEO MapDataReader(IDataReader reader)
		{
		    Sa_losecashback_detailEO ret = new Sa_losecashback_detailEO();
			ret.DetailID = reader.ToString("DetailID");
			ret.OriginalDetailID = ret.DetailID;
			ret.UserID = reader.ToString("UserID");
			ret.DayID = reader.ToDateTime("DayID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.RefundAmount = reader.ToInt64("RefundAmount");
			ret.NotifyStatus = reader.ToInt32("NotifyStatus");
			ret.ReceiveStatus = reader.ToInt32("ReceiveStatus");
			ret.FlowMultip = reader.ToSingle("FlowMultip");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 输返活动用户领取详情表
	/// 【表 sa_losecashback_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Sa_losecashback_detailMO : MySqlTableMO<Sa_losecashback_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sa_losecashback_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sa_losecashback_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sa_losecashback_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sa_losecashback_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sa_losecashback_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sa_losecashback_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sa_losecashback_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DetailID`, `UserID`, `DayID`, `OperatorID`, `CountryID`, `CurrencyID`, `RefundAmount`, `NotifyStatus`, `ReceiveStatus`, `FlowMultip`, `RecDate`) VALUE (@DetailID, @UserID, @DayID, @OperatorID, @CountryID, @CurrencyID, @RefundAmount, @NotifyStatus, @ReceiveStatus, @FlowMultip, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@RefundAmount", item.RefundAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@NotifyStatus", item.NotifyStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@ReceiveStatus", item.ReceiveStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sa_losecashback_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sa_losecashback_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sa_losecashback_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DetailID`, `UserID`, `DayID`, `OperatorID`, `CountryID`, `CurrencyID`, `RefundAmount`, `NotifyStatus`, `ReceiveStatus`, `FlowMultip`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DetailID}','{item.UserID}','{item.DayID.ToString("yyyy-MM-dd HH:mm:ss")}','{item.OperatorID}','{item.CountryID}','{item.CurrencyID}',{item.RefundAmount},{item.NotifyStatus},{item.ReceiveStatus},{item.FlowMultip},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "detailID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string detailID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(detailID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(detailID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string detailID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sa_losecashback_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DetailID, tm_);
		}
		public async Task<int> RemoveAsync(Sa_losecashback_detailEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DetailID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserID
		#region RemoveByDayID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayID">输返的日期</param>
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
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
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
		#region RemoveByRefundAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "refundAmount">输返的奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRefundAmount(long refundAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundAmountData(refundAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRefundAmountAsync(long refundAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundAmountData(refundAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRefundAmountData(long refundAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RefundAmount` = @RefundAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundAmount", refundAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByRefundAmount
		#region RemoveByNotifyStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "notifyStatus">发送通知状态，0-未通知1-已通知</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNotifyStatus(int notifyStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByNotifyStatusData(notifyStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNotifyStatusAsync(int notifyStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByNotifyStatusData(notifyStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNotifyStatusData(int notifyStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NotifyStatus` = @NotifyStatus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyStatus", notifyStatus, MySqlDbType.Int32));
		}
		#endregion // RemoveByNotifyStatus
		#region RemoveByReceiveStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "receiveStatus">用户领取状态，0-未领取1-已领取</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByReceiveStatus(int receiveStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByReceiveStatusData(receiveStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByReceiveStatusAsync(int receiveStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByReceiveStatusData(receiveStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByReceiveStatusData(int receiveStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ReceiveStatus` = @ReceiveStatus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Int32));
		}
		#endregion // RemoveByReceiveStatus
		#region RemoveByFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlowMultip(float flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlowMultipAsync(float flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlowMultipData(float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlowMultip` = @FlowMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
		}
		#endregion // RemoveByFlowMultip
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
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
		public int Put(Sa_losecashback_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sa_losecashback_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sa_losecashback_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DetailID` = @DetailID, `UserID` = @UserID, `DayID` = @DayID, `OperatorID` = @OperatorID, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `RefundAmount` = @RefundAmount, `NotifyStatus` = @NotifyStatus, `ReceiveStatus` = @ReceiveStatus, `FlowMultip` = @FlowMultip WHERE `DetailID` = @DetailID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", item.DetailID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@RefundAmount", item.RefundAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@NotifyStatus", item.NotifyStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@ReceiveStatus", item.ReceiveStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@DetailID_Original", item.HasOriginal ? item.OriginalDetailID : item.DetailID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sa_losecashback_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sa_losecashback_detailEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "detailID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string detailID, string set_, params object[] values_)
		{
			return Put(set_, "`DetailID` = @DetailID", ConcatValues(values_, detailID));
		}
		public async Task<int> PutByPKAsync(string detailID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DetailID` = @DetailID", ConcatValues(values_, detailID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string detailID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DetailID` = @DetailID", tm_, ConcatValues(values_, detailID));
		}
		public async Task<int> PutByPKAsync(string detailID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DetailID` = @DetailID", tm_, ConcatValues(values_, detailID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string detailID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DetailID` = @DetailID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string detailID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DetailID` = @DetailID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIDByPK(string detailID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(detailID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIDByPKAsync(string detailID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(detailID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIDByPKData(string detailID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
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
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserID
		#region PutDayID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// /// <param name = "dayID">输返的日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDayIDByPK(string detailID, DateTime dayID, TransactionManager tm_ = null)
		{
			RepairPutDayIDByPKData(detailID, dayID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDayIDByPKAsync(string detailID, DateTime dayID, TransactionManager tm_ = null)
		{
			RepairPutDayIDByPKData(detailID, dayID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDayIDByPKData(string detailID, DateTime dayID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayID` = @DayID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dayID">输返的日期</param>
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
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string detailID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(detailID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string detailID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(detailID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string detailID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
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
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string detailID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(detailID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string detailID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(detailID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string detailID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
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
		/// /// <param name = "detailID">主键</param>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string detailID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(detailID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string detailID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(detailID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string detailID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
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
		#region PutRefundAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// /// <param name = "refundAmount">输返的奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundAmountByPK(string detailID, long refundAmount, TransactionManager tm_ = null)
		{
			RepairPutRefundAmountByPKData(detailID, refundAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRefundAmountByPKAsync(string detailID, long refundAmount, TransactionManager tm_ = null)
		{
			RepairPutRefundAmountByPKData(detailID, refundAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRefundAmountByPKData(string detailID, long refundAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RefundAmount` = @RefundAmount  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RefundAmount", refundAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "refundAmount">输返的奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundAmount(long refundAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundAmount` = @RefundAmount";
			var parameter_ = Database.CreateInParameter("@RefundAmount", refundAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRefundAmountAsync(long refundAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundAmount` = @RefundAmount";
			var parameter_ = Database.CreateInParameter("@RefundAmount", refundAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRefundAmount
		#region PutNotifyStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// /// <param name = "notifyStatus">发送通知状态，0-未通知1-已通知</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNotifyStatusByPK(string detailID, int notifyStatus, TransactionManager tm_ = null)
		{
			RepairPutNotifyStatusByPKData(detailID, notifyStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNotifyStatusByPKAsync(string detailID, int notifyStatus, TransactionManager tm_ = null)
		{
			RepairPutNotifyStatusByPKData(detailID, notifyStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNotifyStatusByPKData(string detailID, int notifyStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NotifyStatus` = @NotifyStatus  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyStatus", notifyStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "notifyStatus">发送通知状态，0-未通知1-已通知</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNotifyStatus(int notifyStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NotifyStatus` = @NotifyStatus";
			var parameter_ = Database.CreateInParameter("@NotifyStatus", notifyStatus, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNotifyStatusAsync(int notifyStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NotifyStatus` = @NotifyStatus";
			var parameter_ = Database.CreateInParameter("@NotifyStatus", notifyStatus, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNotifyStatus
		#region PutReceiveStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// /// <param name = "receiveStatus">用户领取状态，0-未领取1-已领取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReceiveStatusByPK(string detailID, int receiveStatus, TransactionManager tm_ = null)
		{
			RepairPutReceiveStatusByPKData(detailID, receiveStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutReceiveStatusByPKAsync(string detailID, int receiveStatus, TransactionManager tm_ = null)
		{
			RepairPutReceiveStatusByPKData(detailID, receiveStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutReceiveStatusByPKData(string detailID, int receiveStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ReceiveStatus` = @ReceiveStatus  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "receiveStatus">用户领取状态，0-未领取1-已领取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReceiveStatus(int receiveStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReceiveStatus` = @ReceiveStatus";
			var parameter_ = Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutReceiveStatusAsync(int receiveStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReceiveStatus` = @ReceiveStatus";
			var parameter_ = Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutReceiveStatus
		#region PutFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(string detailID, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(detailID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(string detailID, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(detailID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(string detailID, float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultip(float flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlowMultipAsync(float flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlowMultip
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string detailID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(detailID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string detailID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(detailID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string detailID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DetailID` = @DetailID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
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
		public bool Set(Sa_losecashback_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DetailID) == null)
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
		public async Task<bool> SetAsync(Sa_losecashback_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DetailID) == null)
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
		/// /// <param name = "detailID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sa_losecashback_detailEO GetByPK(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		public async Task<Sa_losecashback_detailEO> GetByPKAsync(string detailID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(detailID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		private void RepairGetByPKData(string detailID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DetailID` = @DetailID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DayID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`DayID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<DateTime> GetDayIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`DayID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RefundAmount（字段）
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRefundAmountByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`RefundAmount`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<long> GetRefundAmountByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`RefundAmount`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NotifyStatus（字段）
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetNotifyStatusByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`NotifyStatus`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetNotifyStatusByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`NotifyStatus`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ReceiveStatus（字段）
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetReceiveStatusByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ReceiveStatus`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<int> GetReceiveStatusByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ReceiveStatus`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetFlowMultipByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`FlowMultip`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<float> GetFlowMultipByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`FlowMultip`", "`DetailID` = @DetailID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "detailID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`DetailID` = @DetailID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string detailID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DetailID", detailID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DetailID` = @DetailID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<Sa_losecashback_detailEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<Sa_losecashback_detailEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<Sa_losecashback_detailEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">输返的日期</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByDayID(DateTime dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByDayIDAsync(DateTime dayID)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">输返的日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByDayID(DateTime dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByDayIDAsync(DateTime dayID, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">输返的日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByDayID(DateTime dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByDayIDAsync(DateTime dayID, int top_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">输返的日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByDayID(DateTime dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByDayIDAsync(DateTime dayID, int top_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">输返的日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByDayID(DateTime dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByDayIDAsync(DateTime dayID, string sort_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">输返的日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByDayID(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByDayIDAsync(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">输返的日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByDayID(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByDayIDAsync(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sa_losecashback_detailEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sa_losecashback_detailEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sa_losecashback_detailEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCountryIDAsync(string countryID, int top_)
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
		public List<Sa_losecashback_detailEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCountryIDAsync(string countryID, string sort_)
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
		public List<Sa_losecashback_detailEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
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
		public List<Sa_losecashback_detailEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByRefundAmount
		
		/// <summary>
		/// 按 RefundAmount（字段） 查询
		/// </summary>
		/// /// <param name = "refundAmount">输返的奖励金额</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRefundAmount(long refundAmount)
		{
			return GetByRefundAmount(refundAmount, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRefundAmountAsync(long refundAmount)
		{
			return await GetByRefundAmountAsync(refundAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundAmount（字段） 查询
		/// </summary>
		/// /// <param name = "refundAmount">输返的奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRefundAmount(long refundAmount, TransactionManager tm_)
		{
			return GetByRefundAmount(refundAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRefundAmountAsync(long refundAmount, TransactionManager tm_)
		{
			return await GetByRefundAmountAsync(refundAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundAmount（字段） 查询
		/// </summary>
		/// /// <param name = "refundAmount">输返的奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRefundAmount(long refundAmount, int top_)
		{
			return GetByRefundAmount(refundAmount, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRefundAmountAsync(long refundAmount, int top_)
		{
			return await GetByRefundAmountAsync(refundAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundAmount（字段） 查询
		/// </summary>
		/// /// <param name = "refundAmount">输返的奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRefundAmount(long refundAmount, int top_, TransactionManager tm_)
		{
			return GetByRefundAmount(refundAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRefundAmountAsync(long refundAmount, int top_, TransactionManager tm_)
		{
			return await GetByRefundAmountAsync(refundAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundAmount（字段） 查询
		/// </summary>
		/// /// <param name = "refundAmount">输返的奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRefundAmount(long refundAmount, string sort_)
		{
			return GetByRefundAmount(refundAmount, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRefundAmountAsync(long refundAmount, string sort_)
		{
			return await GetByRefundAmountAsync(refundAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RefundAmount（字段） 查询
		/// </summary>
		/// /// <param name = "refundAmount">输返的奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRefundAmount(long refundAmount, string sort_, TransactionManager tm_)
		{
			return GetByRefundAmount(refundAmount, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRefundAmountAsync(long refundAmount, string sort_, TransactionManager tm_)
		{
			return await GetByRefundAmountAsync(refundAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RefundAmount（字段） 查询
		/// </summary>
		/// /// <param name = "refundAmount">输返的奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRefundAmount(long refundAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundAmount` = @RefundAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundAmount", refundAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRefundAmountAsync(long refundAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundAmount` = @RefundAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundAmount", refundAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		#endregion // GetByRefundAmount
		#region GetByNotifyStatus
		
		/// <summary>
		/// 按 NotifyStatus（字段） 查询
		/// </summary>
		/// /// <param name = "notifyStatus">发送通知状态，0-未通知1-已通知</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByNotifyStatus(int notifyStatus)
		{
			return GetByNotifyStatus(notifyStatus, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByNotifyStatusAsync(int notifyStatus)
		{
			return await GetByNotifyStatusAsync(notifyStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyStatus（字段） 查询
		/// </summary>
		/// /// <param name = "notifyStatus">发送通知状态，0-未通知1-已通知</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByNotifyStatus(int notifyStatus, TransactionManager tm_)
		{
			return GetByNotifyStatus(notifyStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByNotifyStatusAsync(int notifyStatus, TransactionManager tm_)
		{
			return await GetByNotifyStatusAsync(notifyStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyStatus（字段） 查询
		/// </summary>
		/// /// <param name = "notifyStatus">发送通知状态，0-未通知1-已通知</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByNotifyStatus(int notifyStatus, int top_)
		{
			return GetByNotifyStatus(notifyStatus, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByNotifyStatusAsync(int notifyStatus, int top_)
		{
			return await GetByNotifyStatusAsync(notifyStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyStatus（字段） 查询
		/// </summary>
		/// /// <param name = "notifyStatus">发送通知状态，0-未通知1-已通知</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByNotifyStatus(int notifyStatus, int top_, TransactionManager tm_)
		{
			return GetByNotifyStatus(notifyStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByNotifyStatusAsync(int notifyStatus, int top_, TransactionManager tm_)
		{
			return await GetByNotifyStatusAsync(notifyStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyStatus（字段） 查询
		/// </summary>
		/// /// <param name = "notifyStatus">发送通知状态，0-未通知1-已通知</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByNotifyStatus(int notifyStatus, string sort_)
		{
			return GetByNotifyStatus(notifyStatus, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByNotifyStatusAsync(int notifyStatus, string sort_)
		{
			return await GetByNotifyStatusAsync(notifyStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NotifyStatus（字段） 查询
		/// </summary>
		/// /// <param name = "notifyStatus">发送通知状态，0-未通知1-已通知</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByNotifyStatus(int notifyStatus, string sort_, TransactionManager tm_)
		{
			return GetByNotifyStatus(notifyStatus, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByNotifyStatusAsync(int notifyStatus, string sort_, TransactionManager tm_)
		{
			return await GetByNotifyStatusAsync(notifyStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NotifyStatus（字段） 查询
		/// </summary>
		/// /// <param name = "notifyStatus">发送通知状态，0-未通知1-已通知</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByNotifyStatus(int notifyStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyStatus` = @NotifyStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyStatus", notifyStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByNotifyStatusAsync(int notifyStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyStatus` = @NotifyStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyStatus", notifyStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		#endregion // GetByNotifyStatus
		#region GetByReceiveStatus
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">用户领取状态，0-未领取1-已领取</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByReceiveStatus(int receiveStatus)
		{
			return GetByReceiveStatus(receiveStatus, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByReceiveStatusAsync(int receiveStatus)
		{
			return await GetByReceiveStatusAsync(receiveStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">用户领取状态，0-未领取1-已领取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByReceiveStatus(int receiveStatus, TransactionManager tm_)
		{
			return GetByReceiveStatus(receiveStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByReceiveStatusAsync(int receiveStatus, TransactionManager tm_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">用户领取状态，0-未领取1-已领取</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByReceiveStatus(int receiveStatus, int top_)
		{
			return GetByReceiveStatus(receiveStatus, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByReceiveStatusAsync(int receiveStatus, int top_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">用户领取状态，0-未领取1-已领取</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByReceiveStatus(int receiveStatus, int top_, TransactionManager tm_)
		{
			return GetByReceiveStatus(receiveStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByReceiveStatusAsync(int receiveStatus, int top_, TransactionManager tm_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">用户领取状态，0-未领取1-已领取</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByReceiveStatus(int receiveStatus, string sort_)
		{
			return GetByReceiveStatus(receiveStatus, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByReceiveStatusAsync(int receiveStatus, string sort_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">用户领取状态，0-未领取1-已领取</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByReceiveStatus(int receiveStatus, string sort_, TransactionManager tm_)
		{
			return GetByReceiveStatus(receiveStatus, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByReceiveStatusAsync(int receiveStatus, string sort_, TransactionManager tm_)
		{
			return await GetByReceiveStatusAsync(receiveStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ReceiveStatus（字段） 查询
		/// </summary>
		/// /// <param name = "receiveStatus">用户领取状态，0-未领取1-已领取</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByReceiveStatus(int receiveStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReceiveStatus` = @ReceiveStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByReceiveStatusAsync(int receiveStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReceiveStatus` = @ReceiveStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiveStatus", receiveStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		#endregion // GetByReceiveStatus
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByFlowMultip(float flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByFlowMultipAsync(float flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByFlowMultip(float flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByFlowMultipAsync(float flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByFlowMultip(float flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByFlowMultipAsync(float flowMultip, int top_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByFlowMultip(float flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByFlowMultipAsync(float flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByFlowMultip(float flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByFlowMultipAsync(float flowMultip, string sort_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByFlowMultip(float flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByFlowMultipAsync(float flowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByFlowMultip(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByFlowMultipAsync(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sa_losecashback_detailEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		public async Task<List<Sa_losecashback_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sa_losecashback_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
