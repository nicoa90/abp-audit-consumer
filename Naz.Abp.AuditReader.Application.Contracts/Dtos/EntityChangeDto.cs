using Volo.Abp.Application.Dtos;
using Volo.Abp.Auditing;

namespace Naz.Abp.AuditReader.Dtos
{
    public class EntityChangeDto : EntityDto<Guid>
    {
        public virtual Guid AuditLogId { get; protected set; }

        public virtual Guid? TenantId { get; protected set; }

        public virtual DateTime ChangeTime { get; protected set; }

        public virtual EntityChangeType ChangeType { get; protected set; }

        public virtual Guid? EntityTenantId { get; protected set; }

        public virtual string EntityId { get; protected set; }

        public virtual string EntityTypeFullName { get; protected set; }

        public virtual ICollection<EntityPropertyChangeDto> PropertyChanges { get; protected set; }
        public virtual Dictionary<string, object> ExtraProperties { get; protected set; }

        public virtual string TimeChange
        {
            get
            {
                var result = string.Empty;
                var time=(DateTime.Now - this.ChangeTime).TotalMinutes;
                if (time > 60)
                {
                    time = (DateTime.Now - this.ChangeTime).TotalHours;
                    if (time > 24)
                    {
                        time = (DateTime.Now - this.ChangeTime).TotalDays;
                        result = string.Format("{0} {1}", Convert.ToInt32(time), " days");
                        return result;
                    }
                    result = string.Format("{0} {1}", Convert.ToInt32(time), " hours");
                    return result;
                }

                result = string.Format("{0} {1}", Convert.ToInt32(time), " minutes");
                return result;
            }
        }
        public virtual string Username { get; set; }
    }
}
