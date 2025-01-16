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
	/// 
	/// 【表 sr_oper_sourcetype_day 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sr_oper_sourcetype_dayEO : IRowMapper<Sr_oper_sourcetype_dayEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sr_oper_sourcetype_dayEO()
		{
			this.SourceType = 0;
			this.Bonus = 0;
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
		
		private int _originalSourceType;
		/// <summary>
		/// 【数据库中的原始主键 SourceType 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalSourceType
		{
			get { return _originalSourceType; }
			set { HasOriginal = true; _originalSourceType = value; }
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
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DayID", DayID },  { "SourceType", SourceType },  { "OperatorID", OperatorID }, };
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
		/// 业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int SourceType { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorID { get; set; }
		/// <summary>
		/// bonus数量
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 4)]
		public long Bonus { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sr_oper_sourcetype_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sr_oper_sourcetype_dayEO MapDataReader(IDataReader reader)
		{
		    Sr_oper_sourcetype_dayEO ret = new Sr_oper_sourcetype_dayEO();
			ret.DayID = reader.ToDateTime("DayID");
			ret.OriginalDayID = ret.DayID;
			ret.SourceType = reader.ToInt32("SourceType");
			ret.OriginalSourceType = ret.SourceType;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.Bonus = reader.ToInt64("Bonus");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 sr_oper_sourcetype_day 的操作类】
	/// </summary>
	[Obsolete]
	public class Sr_oper_sourcetype_dayMO : MySqlTableMO<Sr_oper_sourcetype_dayEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sr_oper_sourcetype_day`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sr_oper_sourcetype_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sr_oper_sourcetype_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sr_oper_sourcetype_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sr_oper_sourcetype_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sr_oper_sourcetype_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sr_oper_sourcetype_dayEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DayID`, `SourceType`, `OperatorID`, `Bonus`) VALUE (@DayID, @SourceType, @OperatorID, @Bonus);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", item.SourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
			};
		}
		public int AddByBatch(IEnumerable<Sr_oper_sourcetype_dayEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sr_oper_sourcetype_dayEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sr_oper_sourcetype_dayEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DayID`, `SourceType`, `OperatorID`, `Bonus`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DayID.ToString("yyyy-MM-dd HH:mm:ss")}',{item.SourceType},'{item.OperatorID}',{item.Bonus}),");
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
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime dayID, int sourceType, string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, sourceType, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime dayID, int sourceType, string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, sourceType, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime dayID, int sourceType, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sr_oper_sourcetype_dayEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DayID, item.SourceType, item.OperatorID, tm_);
		}
		public async Task<int> RemoveAsync(Sr_oper_sourcetype_dayEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DayID, item.SourceType, item.OperatorID, tm_);
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
		#region RemoveBySourceType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySourceType(int sourceType, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTypeData(sourceType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySourceTypeAsync(int sourceType, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTypeData(sourceType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySourceTypeData(int sourceType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SourceType` = @SourceType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32));
		}
		#endregion // RemoveBySourceType
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
		#region RemoveByBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bonus">bonus数量</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBonus(long bonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusData(bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBonusAsync(long bonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusData(bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBonusData(long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Bonus` = @Bonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByBonus
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
		public int Put(Sr_oper_sourcetype_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sr_oper_sourcetype_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sr_oper_sourcetype_dayEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayID` = @DayID, `SourceType` = @SourceType, `OperatorID` = @OperatorID, `Bonus` = @Bonus WHERE `DayID` = @DayID_Original AND `SourceType` = @SourceType_Original AND `OperatorID` = @OperatorID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", item.SourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID_Original", item.HasOriginal ? item.OriginalDayID : item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType_Original", item.HasOriginal ? item.OriginalSourceType : item.SourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sr_oper_sourcetype_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sr_oper_sourcetype_dayEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, int sourceType, string operatorID, string set_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", ConcatValues(values_, dayID, sourceType, operatorID));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, int sourceType, string operatorID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", ConcatValues(values_, dayID, sourceType, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, int sourceType, string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", tm_, ConcatValues(values_, dayID, sourceType, operatorID));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, int sourceType, string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", tm_, ConcatValues(values_, dayID, sourceType, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, int sourceType, string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime dayID, int sourceType, string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutSourceType
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceType(int sourceType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceType` = @SourceType";
			var parameter_ = Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceTypeAsync(int sourceType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceType` = @SourceType";
			var parameter_ = Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceType
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
		#region PutBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "bonus">bonus数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusByPK(DateTime dayID, int sourceType, string operatorID, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(dayID, sourceType, operatorID, bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBonusByPKAsync(DateTime dayID, int sourceType, string operatorID, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(dayID, sourceType, operatorID, bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBonusByPKData(DateTime dayID, int sourceType, string operatorID, long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus  WHERE `DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bonus">bonus数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonus(long bonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus";
			var parameter_ = Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBonusAsync(long bonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus";
			var parameter_ = Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBonus
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sr_oper_sourcetype_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.SourceType, item.OperatorID) == null)
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
		public async Task<bool> SetAsync(Sr_oper_sourcetype_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.SourceType, item.OperatorID) == null)
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
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sr_oper_sourcetype_dayEO GetByPK(DateTime dayID, int sourceType, string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, sourceType, operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sr_oper_sourcetype_dayEO.MapDataReader);
		}
		public async Task<Sr_oper_sourcetype_dayEO> GetByPKAsync(DateTime dayID, int sourceType, string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, sourceType, operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sr_oper_sourcetype_dayEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime dayID, int sourceType, string operatorID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 DayID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIDByPK(DateTime dayID, int sourceType, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`DayID`", "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<DateTime> GetDayIDByPKAsync(DateTime dayID, int sourceType, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`DayID`", "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceType（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSourceTypeByPK(DateTime dayID, int sourceType, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`SourceType`", "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetSourceTypeByPKAsync(DateTime dayID, int sourceType, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`SourceType`", "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(DateTime dayID, int sourceType, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(DateTime dayID, int sourceType, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Bonus（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBonusByPK(DateTime dayID, int sourceType, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Bonus`", "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<long> GetBonusByPKAsync(DateTime dayID, int sourceType, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Bonus`", "`DayID` = @DayID AND `SourceType` = @SourceType AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByDayID(DateTime dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByDayIDAsync(DateTime dayID)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByDayID(DateTime dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByDayIDAsync(DateTime dayID, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByDayID(DateTime dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByDayIDAsync(DateTime dayID, int top_)
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
		public List<Sr_oper_sourcetype_dayEO> GetByDayID(DateTime dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByDayID(DateTime dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_)
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
		public List<Sr_oper_sourcetype_dayEO> GetByDayID(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_, TransactionManager tm_)
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
		public List<Sr_oper_sourcetype_dayEO> GetByDayID(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_sourcetype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_sourcetype_dayEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetBySourceType
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetBySourceType(int sourceType)
		{
			return GetBySourceType(sourceType, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetBySourceTypeAsync(int sourceType)
		{
			return await GetBySourceTypeAsync(sourceType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetBySourceType(int sourceType, TransactionManager tm_)
		{
			return GetBySourceType(sourceType, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetBySourceTypeAsync(int sourceType, TransactionManager tm_)
		{
			return await GetBySourceTypeAsync(sourceType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetBySourceType(int sourceType, int top_)
		{
			return GetBySourceType(sourceType, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetBySourceTypeAsync(int sourceType, int top_)
		{
			return await GetBySourceTypeAsync(sourceType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetBySourceType(int sourceType, int top_, TransactionManager tm_)
		{
			return GetBySourceType(sourceType, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetBySourceTypeAsync(int sourceType, int top_, TransactionManager tm_)
		{
			return await GetBySourceTypeAsync(sourceType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetBySourceType(int sourceType, string sort_)
		{
			return GetBySourceType(sourceType, 0, sort_, null);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetBySourceTypeAsync(int sourceType, string sort_)
		{
			return await GetBySourceTypeAsync(sourceType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetBySourceType(int sourceType, string sort_, TransactionManager tm_)
		{
			return GetBySourceType(sourceType, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetBySourceTypeAsync(int sourceType, string sort_, TransactionManager tm_)
		{
			return await GetBySourceTypeAsync(sourceType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetBySourceType(int sourceType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SourceType` = @SourceType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_sourcetype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetBySourceTypeAsync(int sourceType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SourceType` = @SourceType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_sourcetype_dayEO.MapDataReader);
		}
		#endregion // GetBySourceType
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sr_oper_sourcetype_dayEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sr_oper_sourcetype_dayEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sr_oper_sourcetype_dayEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_sourcetype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_sourcetype_dayEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByBonus
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus数量</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByBonus(long bonus)
		{
			return GetByBonus(bonus, 0, string.Empty, null);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByBonusAsync(long bonus)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus数量</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByBonus(long bonus, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByBonusAsync(long bonus, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus数量</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByBonus(long bonus, int top_)
		{
			return GetByBonus(bonus, top_, string.Empty, null);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByBonusAsync(long bonus, int top_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByBonus(long bonus, int top_, TransactionManager tm_)
		{
			return GetByBonus(bonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByBonusAsync(long bonus, int top_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByBonus(long bonus, string sort_)
		{
			return GetByBonus(bonus, 0, sort_, null);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByBonusAsync(long bonus, string sort_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus数量</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByBonus(long bonus, string sort_, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, sort_, tm_);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByBonusAsync(long bonus, string sort_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus数量</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sr_oper_sourcetype_dayEO> GetByBonus(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sr_oper_sourcetype_dayEO.MapDataReader);
		}
		public async Task<List<Sr_oper_sourcetype_dayEO>> GetByBonusAsync(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sr_oper_sourcetype_dayEO.MapDataReader);
		}
		#endregion // GetByBonus
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
