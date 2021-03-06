using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Ecs.Model.V20140526;

using Xunit;

namespace Aliyun.Acs.Feature.Test.Credential
{
    public class CredentialsTest : FeatureTestBase
    {
        [Trait("Category", "FeatureTest")]
        [Fact]
        public void SdkManageTokenTest()
        {
            DefaultProfile profile = DefaultProfile.GetProfile("cn-hangzhou", this.GetBasicAccessKeyId(), this.GetBasicAccessKeySecret());
            BasicCredentials basicCredential = new BasicCredentials(this.GetBasicAccessKeyId(), this.GetBasicAccessKeySecret());
            STSAssumeRoleSessionCredentialsProvider provider = new STSAssumeRoleSessionCredentialsProvider(basicCredential, this.GetRoleArn(), profile);

            DefaultAcsClient client = new DefaultAcsClient(profile, provider);

            DescribeInstancesRequest request = new DescribeInstancesRequest();
            DescribeInstancesResponse response = client.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.True(0 <= response.TotalCount);
        }
    }
}
