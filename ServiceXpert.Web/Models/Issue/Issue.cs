﻿namespace ServiceXpert.Web.Models.Issue;
public class Issue : ModelBase
{
    public int IssueId { get; set; }

    public string IssueKey { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public int IssueStatusId { get; set; }

    public IssueStatus? IssueStatus { get; set; }

    public int IssuePriorityId { get; set; }

    public IssuePriority? IssuePriority { get; set; }

    public List<Comment.Comment> Comments { get; set; }

    public Issue()
    {
        this.Comments = [];
    }
}
