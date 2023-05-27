using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Naz.Abp.AuditReader.Dtos
{
    public class AuditLogActionsDto : EntityDto<Guid>
    {
        public virtual Guid? TenantId { get; protected set; }

        public virtual Guid AuditLogId { get; protected set; }

        public virtual string ServiceName { get; protected set; }

        public virtual string MethodName { get; protected set; }

        public virtual string Parameters { get; protected set; }

        public virtual DateTime ExecutionTime { get; protected set; }

        public virtual int ExecutionDuration { get; protected set; }

    }
}
