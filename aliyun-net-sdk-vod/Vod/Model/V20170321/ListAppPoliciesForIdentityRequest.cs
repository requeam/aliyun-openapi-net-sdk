/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class ListAppPoliciesForIdentityRequest : RpcAcsRequest<ListAppPoliciesForIdentityResponse>
    {
        public ListAppPoliciesForIdentityRequest()
            : base("vod", "2017-03-21", "ListAppPoliciesForIdentity", "vod", "openAPI")
        {
        }

		private string identityName;

		private long? resourceOwnerId;

		private string identityType;

		private string resourceOwnerAccount;

		private string appId;

		private long? ownerId;

		public string IdentityName
		{
			get
			{
				return identityName;
			}
			set	
			{
				identityName = value;
				DictionaryUtil.Add(QueryParameters, "IdentityName", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string IdentityType
		{
			get
			{
				return identityType;
			}
			set	
			{
				identityType = value;
				DictionaryUtil.Add(QueryParameters, "IdentityType", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListAppPoliciesForIdentityResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAppPoliciesForIdentityResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
