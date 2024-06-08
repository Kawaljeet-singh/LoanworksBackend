namespace LoanworksBackend.Modules.Management.Core.Workflow;

/// <summary>
/// This contains a roundup summary of workflow data (from workflow, task, alert and notification entities)
/// </summary>
public class WorkflowConfig
{
    public string TopLevel { get; set; } = default!;
    public string SubLevel { get; set; } = default!;
    public string Workflow { get; set; } = default!;
    public string Taskname { get; set; } = default!;
    public string? TaskStatus { get; set; }
    public string? AlertName { get; set; }
    public string? NotificationType { get; set; }
    public string? NotificationProfile { get; set; }
}
