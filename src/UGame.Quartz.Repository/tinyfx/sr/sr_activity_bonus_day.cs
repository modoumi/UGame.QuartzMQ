/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-07-04 16: 21:09
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
	/// 
	/// 【表 sr_activity_bonus_day 的实体类】
	/// </summary>
	[DataContract]
	public class Sr_activity_bonus_dayEO : IRowMapper<Sr_activity_bonus_dayEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sr_activity_bonus_dayEO()
		{
			this.Amount = 0;
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
		
		private string _originalActivityCode;
		/// <summary>
		/// 【数据库中的原始主键 ActivityCode 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalActivityCode
		{
			get { return _originalActivityCode; }
			set { HasOriginal = true; _originalActivityCode = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DayID", DayID },  { "ActivityCode", ActivityCode }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 
		/// 【主键 date】
		/// </summary>
		[DataMember(Order = 1)]
		public DateTime DayID { get; set; }
		/// <summary>
		/// 
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string ActivityCode { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 4)]
		public long Amount { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sr_activity_bonus_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sr_activity_bonus_dayEO MapDataReader(IDataReader reader)
		{
		    Sr_activity_bonus_dayEO ret = new Sr_activity_bonus_dayEO();
			ret.DayID = reader.ToDateTime("DayID");
			ret.OriginalDayID = ret.DayID;
			ret.ActivityCode = reader.ToString("ActivityCode");
			ret.OriginalActivityCode = ret.ActivityCode;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.Amount = reader.ToInt64("Amount");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sr_activity_bonus_day 的操作类】
	/// </summary>
	public class Sr_activity_bonus_dayMO : MySqlTableMO<Sr_activity_bonus_dayEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sr_activity_bonus_day`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sr_activity_bonus_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sr_activity_bonus_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sr_activity_bonus_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sr_activity_bonus_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sr_activity_bonus_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sr_activity_bonus_dayEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DayID`, `ActivityCode`, `OperatorID`, `Amount`) VALUE (@DayID, @ActivityCode, @OperatorID, @Amount);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", item.ActivityCode, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.Int64),
			};
		}
		public int AddByBatch(IEnumerable<Sr_activity_bonus_dayEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sr_activity_bonus_dayEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sr_activity_bonus_dayEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DayID`, `ActivityCode`, `OperatorID`, `Amount`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DayID.ToString("yyyy-MM-dd HH:mm:ss")}','{item.ActivityCode}','{item.OperatorID}',{item.Amount}),");
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
		/// /// <param name = "dayID"></param>
		/// /// <param name = "activityCode"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime dayID, string activityCode, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, activityCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime dayID, string activityCode, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, activityCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime dayID, string activityCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID AND `ActivityCode` = @ActivityCode";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sr_activity_bonus_dayEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DayID, item.ActivityCode, tm_);
		}
		public async Task<int> RemoveAsync(Sr_activity_bonus_dayEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DayID, item.ActivityCode, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByDayID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayID"></param>
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
		#region RemoveByActivityCode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "activityCode"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActivityCode(string activityCode, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityCodeData(activityCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActivityCodeAsync(string activityCode, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityCodeData(activityCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActivityCodeData(string activityCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ActivityCode` = @ActivityCode";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar));
		}
		#endregion // RemoveByActivityCode
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID"></param>
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
		#region RemoveByAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAmount(long amount, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountData(amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAmountAsync(long amount, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountData(amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAmountData(long amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Amount` = @Amount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
		}
		#endregion // RemoveByAmount
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
		public int Put(Sr_activity_bonus_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sr_activity_bonus_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sr_activity_bonus_dayEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayID` = @DayID, `ActivityCode` = @ActivityCode, `OperatorID` = @OperatorID, `Amount` = @Amount WHERE `DayID` = @DayID_Original AND `ActivityCode` = @ActivityCode_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", item.ActivityCode, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID_Original", item.HasOriginal ? item.OriginalDayID : item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode_Original", item.HasOriginal ? item.OriginalActivityCode : item.ActivityCode, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sr_activity_bonus_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sr_activity_bonus_dayEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "dayID"></param>
		/// /// <param name = "activityCode"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string activityCode, string set_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", ConcatValues(values_, dayID, activityCode));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string activityCode, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", ConcatValues(values_, dayID, activityCode));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// /// <param name = "activityCode"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string activityCode, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", tm_, ConcatValues(values_, dayID, activityCode));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string activityCode, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", tm_, ConcatValues(values_, dayID, activityCode));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// /// <param name = "activityCode"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string activityCode, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string activityCode, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutDayID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dayID"></param>
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
		#region PutActivityCode
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "activityCode"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityCode(string activityCode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityCode` = @ActivityCode";
			var parameter_ = Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActivityCodeAsync(string activityCode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityCode` = @ActivityCode";
			var parameter_ = Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActivityCode
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// /// <param name = "activityCode"></param>
		/// /// <param name = "operatorID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(DateTime dayID, string activityCode, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(dayID, activityCode, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(DateTime dayID, string activityCode, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(dayID, activityCode, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(DateTime dayID, string activityCode, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `DayID` = @DayID AND `ActivityCode` = @ActivityCode";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID"></param>
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
		#region PutAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// /// <param name = "activityCode"></param>
		/// /// <param name = "amount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountByPK(DateTime dayID, string activityCode, long amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(dayID, activityCode, amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAmountByPKAsync(DateTime dayID, string activityCode, long amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(dayID, activityCode, amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAmountByPKData(DateTime dayID, string activityCode, long amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Amount` = @Amount  WHERE `DayID` = @DayID AND `ActivityCode` = @ActivityCode";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmount(long amount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Amount` = @Amount";
			var parameter_ = Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAmountAsync(long amount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Amount` = @Amount";
			var parameter_ = Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAmount
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sr_activity_bonus_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.ActivityCode) == null)
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
		public async Task<bool> SetAsync(Sr_activity_bonus_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.ActivityCode) == null)
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
		/// /// <param name = "dayID"></param>
		/// /// <param name = "activityCode"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sr_activity_bonus_dayEO GetByPK(DateTime dayID, string activityCode, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, activityCode, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sr_activity_bonus_dayEO.MapDataReader);
		}
		public async Task<Sr_activity_bonus_dayEO> GetByPKAsync(DateTime dayID, string activityCode, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, activityCode, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sr_activity_bonus_dayEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime dayID, string activityCode, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
		{
			sql_ = BuildSelectSQL("`DayID` = @DayID AND `ActivityCode` = @ActivityCode", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 DayID（字段）
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// /// <param name = "activityCode"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIDByPK(DateTime dayID, string activityCode, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`DayID`", "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", paras_, tm_);
		}
		public async Task<DateTime> GetDayIDByPKAsync(DateTime dayID, string activityCode, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`DayID`", "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActivityCode（字段）
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// /// <param name = "activityCode"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetActivityCodeByPK(DateTime dayID, string activityCode, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ActivityCode`", "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", paras_, tm_);
		}
		public async Task<string> GetActivityCodeByPKAsync(DateTime dayID, string activityCode, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ActivityCode`", "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// /// <param name = "activityCode"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(DateTime dayID, string activityCode, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(DateTime dayID, string activityCode, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Amount（字段）
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// /// <param name = "activityCode"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetAmountByPK(DateTime dayID, string activityCode, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Amount`", "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", paras_, tm_);
		}
		public async Task<long> GetAmountByPKAsync(DateTime dayID, string activityCode, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Amount`", "`DayID` = @DayID AND `ActivityCode` = @ActivityCode", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByDayID(DateTime dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByDayIDAsync(DateTime dayID)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByDayID(DateTime dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByDayIDAsync(DateTime dayID, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByDayID(DateTime dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByDayIDAsync(DateTime dayID, int top_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByDayID(DateTime dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByDayID(DateTime dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByDayID(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByDayID(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_activity_bonus_dayEO.MapDataReader);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_activity_bonus_dayEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetByActivityCode
		
		/// <summary>
		/// 按 ActivityCode（字段） 查询
		/// </summary>
		/// /// <param name = "activityCode"></param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByActivityCode(string activityCode)
		{
			return GetByActivityCode(activityCode, 0, string.Empty, null);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByActivityCodeAsync(string activityCode)
		{
			return await GetByActivityCodeAsync(activityCode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityCode（字段） 查询
		/// </summary>
		/// /// <param name = "activityCode"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByActivityCode(string activityCode, TransactionManager tm_)
		{
			return GetByActivityCode(activityCode, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByActivityCodeAsync(string activityCode, TransactionManager tm_)
		{
			return await GetByActivityCodeAsync(activityCode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityCode（字段） 查询
		/// </summary>
		/// /// <param name = "activityCode"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByActivityCode(string activityCode, int top_)
		{
			return GetByActivityCode(activityCode, top_, string.Empty, null);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByActivityCodeAsync(string activityCode, int top_)
		{
			return await GetByActivityCodeAsync(activityCode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityCode（字段） 查询
		/// </summary>
		/// /// <param name = "activityCode"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByActivityCode(string activityCode, int top_, TransactionManager tm_)
		{
			return GetByActivityCode(activityCode, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByActivityCodeAsync(string activityCode, int top_, TransactionManager tm_)
		{
			return await GetByActivityCodeAsync(activityCode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityCode（字段） 查询
		/// </summary>
		/// /// <param name = "activityCode"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByActivityCode(string activityCode, string sort_)
		{
			return GetByActivityCode(activityCode, 0, sort_, null);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByActivityCodeAsync(string activityCode, string sort_)
		{
			return await GetByActivityCodeAsync(activityCode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActivityCode（字段） 查询
		/// </summary>
		/// /// <param name = "activityCode"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByActivityCode(string activityCode, string sort_, TransactionManager tm_)
		{
			return GetByActivityCode(activityCode, 0, sort_, tm_);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByActivityCodeAsync(string activityCode, string sort_, TransactionManager tm_)
		{
			return await GetByActivityCodeAsync(activityCode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActivityCode（字段） 查询
		/// </summary>
		/// /// <param name = "activityCode"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByActivityCode(string activityCode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityCode` = @ActivityCode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_activity_bonus_dayEO.MapDataReader);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByActivityCodeAsync(string activityCode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActivityCode` = @ActivityCode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActivityCode", activityCode, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_activity_bonus_dayEO.MapDataReader);
		}
		#endregion // GetByActivityCode
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_activity_bonus_dayEO.MapDataReader);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_activity_bonus_dayEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByAmount
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByAmount(long amount)
		{
			return GetByAmount(amount, 0, string.Empty, null);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByAmountAsync(long amount)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByAmount(long amount, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByAmountAsync(long amount, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByAmount(long amount, int top_)
		{
			return GetByAmount(amount, top_, string.Empty, null);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByAmountAsync(long amount, int top_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByAmount(long amount, int top_, TransactionManager tm_)
		{
			return GetByAmount(amount, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByAmountAsync(long amount, int top_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByAmount(long amount, string sort_)
		{
			return GetByAmount(amount, 0, sort_, null);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByAmountAsync(long amount, string sort_)
		{
			return await GetByAmountAsync(amount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByAmount(long amount, string sort_, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, sort_, tm_);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByAmountAsync(long amount, string sort_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_activity_bonus_dayEO> GetByAmount(long amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_activity_bonus_dayEO.MapDataReader);
		}
		public async Task<List<Sr_activity_bonus_dayEO>> GetByAmountAsync(long amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_activity_bonus_dayEO.MapDataReader);
		}
		#endregion // GetByAmount
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
