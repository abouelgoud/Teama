using System;
using System.Collections.Generic;
using System.Text;

namespace Teama.Domain.Enums
{
    public enum StatusTypes
    {
        Active,
        AppointmentStatus,

    }
    public enum Statuses
    {
        Active,
        InActive,
        Pending,
        Verified,
        Booked,
        Scheduled,
        Completed,
        Paid,
        Cancelled,
        Archived,
        Waiting


    }
    public enum GradeTypes
    {
        New,
        Used
    }
    public enum DiscountTypes
    {
        Amount,
        Percentage,

    }
    public enum PaymentMethods
    {
        Cash,
        Mada,

    }
    public enum OrderProductStatus
    {
        Active,
        Cancelled,

    }

    public enum DeliveryStatus
    {
        Completed,
        Cancelled,

    }
    public enum RequestStatus
    {
        Completed,
        Cancelled,

    }
    public enum OnlineStatus
    {
        OnLine,
        OffLine,

    }
    public enum SubscribtionType
    {
        Basic,
        Silver,
        Gold

    } 
    public enum Priority
    {
        Urgent,
        High,
        Meduim,
        Low

    }
}
