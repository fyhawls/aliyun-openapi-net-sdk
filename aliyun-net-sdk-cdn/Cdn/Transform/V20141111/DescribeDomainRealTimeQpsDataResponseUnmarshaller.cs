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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainRealTimeQpsDataResponseUnmarshaller
    {
        public static DescribeDomainRealTimeQpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainRealTimeQpsDataResponse describeDomainRealTimeQpsDataResponse = new DescribeDomainRealTimeQpsDataResponse();

			describeDomainRealTimeQpsDataResponse.HttpResponse = context.HttpResponse;
			describeDomainRealTimeQpsDataResponse.RequestId = context.StringValue("DescribeDomainRealTimeQpsData.RequestId");

			List<DescribeDomainRealTimeQpsDataResponse.DescribeDomainRealTimeQpsData_QpsModel> describeDomainRealTimeQpsDataResponse_data = new List<DescribeDomainRealTimeQpsDataResponse.DescribeDomainRealTimeQpsData_QpsModel>();
			for (int i = 0; i < context.Length("DescribeDomainRealTimeQpsData.Data.Length"); i++) {
				DescribeDomainRealTimeQpsDataResponse.DescribeDomainRealTimeQpsData_QpsModel qpsModel = new DescribeDomainRealTimeQpsDataResponse.DescribeDomainRealTimeQpsData_QpsModel();
				qpsModel.Qps = context.FloatValue("DescribeDomainRealTimeQpsData.Data["+ i +"].Qps");
				qpsModel.TimeStamp = context.StringValue("DescribeDomainRealTimeQpsData.Data["+ i +"].TimeStamp");

				describeDomainRealTimeQpsDataResponse_data.Add(qpsModel);
			}
			describeDomainRealTimeQpsDataResponse.Data = describeDomainRealTimeQpsDataResponse_data;
        
			return describeDomainRealTimeQpsDataResponse;
        }
    }
}