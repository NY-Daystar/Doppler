using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doppler.Tests
{
    [TestClass]
    public class DopplerConfigurationTests
    {
        [TestMethod]
        public void TryGetConfiguration()
        {
            DopplerConfig config = new();

            Assert.IsNotNull(config);
        }
    }
}
