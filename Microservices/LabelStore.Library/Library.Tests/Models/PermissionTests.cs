using System;
using SleeDigital.LabelStore.Library.Models;

namespace SleeDigital.LabelStore.Library.Tests.Models
{
    public class PermissionTests
    {
        [Fact]
        public void Assert_Permission_Model_Has_String_Name_Property()
        {
            // Arrange

            string name = "read/write";

            // Act
            Permission permission = new Permission()
            {
                Name = name
        };

            // Assert

            Assert.True(name == permission.Name);

        }

        [Fact]
        public void Assert_Permission_Model_Has_String_Setting_Property()
        {
            // Arrange

            string setting = "RW";

            // Act
            Permission permission = new Permission()
            {
                Setting = setting
            };

            // Assert

            Assert.True(setting == permission.Setting);

        }

    }
}

