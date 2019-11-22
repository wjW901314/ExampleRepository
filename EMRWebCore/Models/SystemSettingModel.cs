namespace EMRWebCore.Models
{
    public class SystemSettingModel
    {
        /// <summary>
        /// 医疗服务登记号（住院号）
        /// </summary>
        public string zyId { get; set; }

        /// <summary>
        /// 当前操作员编码（医生id）
        /// </summary>
        public string doctorId { get; set; }

        /// <summary>
        /// 当前操作员姓名
        /// </summary>
        public string doctorName { get; set; }

        /// <summary>
        /// 科室编码
        /// </summary>
        public string departmentId { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        public string departmentName { get; set; }

        /// <summary>
        /// 医疗机构编码
        /// </summary>
        public string orgId { get; set; }

        /// <summary>
        /// 医疗机构名称
        /// </summary>
        public string orgName { get; set; }

        /// <summary>
        /// 微服务链接地址
        /// </summary>
        public string serviceUrl { get; set; }
    }
}