﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backendv3.Models
{
    public class UserFriend
    {
        public UserFriend() { }
        public UserFriend(CreateUserFriendRequest create)
        {
            UserId = create.UserId;
            FriendId = create.FriendId;
        }

        public string UserId { get; set; }
        public User User { get; set; }
        public string FriendId { get; set; }
        public User Friend { get; set; }
    }

    public class CreateUserFriendRequest
    {
        public string UserId { get; set; }
        public string FriendId { get; set; }
    }
}