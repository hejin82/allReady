﻿using MediatR;

namespace AllReady.Features.Notifications
{
    public class VolunteerSignupNotification : IAsyncNotification
    {
        public int TaskId { get; set; }
        public string UserId { get; set; }
    }
}
