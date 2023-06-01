﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Blazor4.Models;

/// <summary>
/// Audit table tracking all DDL changes made to the AdventureWorks database. Data is captured by the database trigger ddlDatabaseTriggerLog.
/// </summary>
public partial class DatabaseLog
{
    /// <summary>
    /// Primary key for DatabaseLog records.
    /// </summary>
    public int DatabaseLogId { get; set; }

    /// <summary>
    /// The date and time the DDL change occurred.
    /// </summary>
    public DateTime PostTime { get; set; }

    /// <summary>
    /// The user who implemented the DDL change.
    /// </summary>
    public string DatabaseUser { get; set; }

    /// <summary>
    /// The type of DDL statement that was executed.
    /// </summary>
    public string Event { get; set; }

    /// <summary>
    /// The schema to which the changed object belongs.
    /// </summary>
    public string Schema { get; set; }

    /// <summary>
    /// The object that was changed by the DDL statment.
    /// </summary>
    public string Object { get; set; }

    /// <summary>
    /// The exact Transact-SQL statement that was executed.
    /// </summary>
    public string Tsql { get; set; }

    /// <summary>
    /// The raw XML data generated by database trigger.
    /// </summary>
    public string XmlEvent { get; set; }
}