﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Griffin.MvcContrib.Providers.Membership.SqlRepository;

namespace Griffin.MvcContrib.Areas.Griffin.Models.Account
{
	public class ListModel
	{
		public MembershipUserCollection Accounts { get; set; }
		public int TotalCount { get; set; }
	}
}