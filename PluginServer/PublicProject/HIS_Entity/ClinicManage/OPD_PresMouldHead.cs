﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFWCoreLib.CoreFrame.Orm;
using EFWCoreLib.CoreFrame.Business;

namespace HIS_Entity.ClinicManage
{
    [Serializable]
    [Table(TableName = "OPD_PresMouldHead", EntityType = EntityType.Table, IsGB = false)]
    public class OPD_PresMouldHead:AbstractEntity
    {
        private int _presmouldheadid;
        /// <summary>
        /// 模板ID
        /// </summary>
        [Column(FieldName = "PresMouldHeadID", DataKey = true, Match = "", IsInsert = false)]
        public int PresMouldHeadID
        {
            get { return  _presmouldheadid; }
            set {  _presmouldheadid = value; }
        }

        private int _pid;
        /// <summary>
        /// 父模板ID
        /// </summary>
        [Column(FieldName = "PID", DataKey = false, Match = "", IsInsert = true)]
        public int PID
        {
            get { return  _pid; }
            set {  _pid = value; }
        }

        private string  _moduldname;
        /// <summary>
        /// 模板名
        /// </summary>
        [Column(FieldName = "ModuldName", DataKey = false, Match = "", IsInsert = true)]
        public string ModuldName
        {
            get { return  _moduldname; }
            set {  _moduldname = value; }
        }

        private int  _mouldtype;
        /// <summary>
        /// 模板类型：0模板分类1处方模板
        /// </summary>
        [Column(FieldName = "MouldType", DataKey = false, Match = "", IsInsert = true)]
        public int MouldType
        {
            get { return  _mouldtype; }
            set {  _mouldtype = value; }
        }

        private int  _prestype;
        /// <summary>
        /// 处方类型：0西成药模板，1中草药模板，2费用模板
        /// </summary>
        [Column(FieldName = "PresType", DataKey = false, Match = "", IsInsert = true)]
        public int PresType
        {
            get { return  _prestype; }
            set {  _prestype = value; }
        }

        private int  _modullevel;
        /// <summary>
        /// 模板级别：0院级模板，1科室级模板，2个人级模板
        /// </summary>
        [Column(FieldName = "ModulLevel", DataKey = false, Match = "", IsInsert = true)]
        public int ModulLevel
        {
            get { return  _modullevel; }
            set {  _modullevel = value; }
        }

        private int  _createempid;
        /// <summary>
        /// 创建人ID
        /// </summary>
        [Column(FieldName = "CreateEmpID", DataKey = false, Match = "", IsInsert = true)]
        public int CreateEmpID
        {
            get { return  _createempid; }
            set {  _createempid = value; }
        }

        private int  _createdeptid;
        /// <summary>
        /// 创建科室ID
        /// </summary>
        [Column(FieldName = "CreateDeptID", DataKey = false, Match = "", IsInsert = true)]
        public int CreateDeptID
        {
            get { return  _createdeptid; }
            set {  _createdeptid = value; }
        }

        private DateTime  _createdate;
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(FieldName = "CreateDate", DataKey = false, Match = "", IsInsert = true)]
        public DateTime CreateDate
        {
            get { return  _createdate; }
            set {  _createdate = value; }
        }

        private int  _delflag;
        /// <summary>
        /// 删除标志
        /// </summary>
        [Column(FieldName = "DelFlag", DataKey = false, Match = "", IsInsert = true)]
        public int DelFlag
        {
            get { return  _delflag; }
            set {  _delflag = value; }
        }

    }
}
