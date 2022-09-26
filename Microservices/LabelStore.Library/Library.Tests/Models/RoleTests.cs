using System;
using SleeDigital.LabelStore.Library.Models;

namespace SleeDigital.LabelStore.Library.Tests.Models
{
    public class RoleTests
    {
        [Fact]
        public void Assert_Role_Model_Has_String_Id_Property()
        {
            // Arrange

            string id = "abc-123";

            // Act
            Role role = new Role()
            {
                id = id
            };

            // Assert

            Assert.True(id == role.id);

        }

        [Fact]
        public void Assert_Role_Model_Id_Has_Value_After_Initiation()
        {
            // Arrange


            // Act
            Role role = new Role();

            // Assert
            Assert.NotEmpty(role.id);

        }

        [Fact]
        public void Assert_Role_Model_Has_String_Name_Property()
        {
            // Arrange

            string name = "sys_admin";

            // Act
            Role role = new Role()
            {
                Name = name
            };

            // Assert

            Assert.True(name == role.Name);

        }

        [Fact]
        public void Assert_Role_Model_Has_String_Description_Property()
        {
            // Arrange

            string description = "System's Adminstrator Role";

            // Act
            Role role = new Role()
            {
                Description = description
            };

            // Assert

            Assert.True(description == role.Description);

        }

        [Fact]
        public void Assert_Role_Model_Has_List_Permissions_Property()
        {
            // Arrange

            Permission permission1 = new Permission()
            {
                Name = "read",
                Setting = "R",
            };

            Permission permission2 = new Permission()
            {
                Name = "read/Write",
                Setting = "RW",
            };

            // Act
            Role role = new Role()
            {
            };

            role.Permissions.Add(permission1);
            role.Permissions.Add(permission2);

            // Assert

            Assert.True(permission1.Name == role.Permissions[0].Name);
            Assert.True(permission1.Setting == role.Permissions[0].Setting);
            Assert.True(permission2.Name == role.Permissions[1].Name);
            Assert.True(permission2.Setting == role.Permissions[1].Setting);

        }

    }
}

