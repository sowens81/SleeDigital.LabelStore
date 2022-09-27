using SleeDigital.LabelStore.Library.Models;

namespace SleeDigital.LabelStore.Library.Tests.Models
{
    public class UserTests
    {
        [Fact]
        public void Assert_User_Model_Has_String_Id_Property()
        {
            // Arrange

            string id = "abc-123";

            // Act
            User user = new User()
            {
                id = id
            };

            // Assert

            Assert.True(id == user.id);

        }

        [Fact]
        public void Assert_User_Model_Id_Has_Value_After_Initiation()
        {
            // Arrange


            // Act
            User user = new User();

            // Assert
            Assert.NotEmpty(user.id);

        }

        [Fact]
        public void Assert_User_Model_Has_String_AzureObjectId_Property()
        {
            // Arrange

            string azureObjectId = Guid.NewGuid().ToString();

            // Act
            User user = new User()
            {
                AzureObjectId = azureObjectId
            };

            // Assert

            Assert.True(azureObjectId == user.AzureObjectId);

        }

        [Fact]
        public void Assert_User_Model_Has_String_Email_Address_Property()
        {
            // Arrange

            string emailAddress = "user@user.com";

            // Act
            User user = new User()
            {
                EmailAddress = emailAddress
            };

            // Assert

            Assert.True(emailAddress == user.EmailAddress);

        }

        [Fact]
        public void Assert_User_Model_Has_String_First_Name_Property()
        {
            // Arrange

            string firstName = "john";

            // Act
            User user = new User()
            {
                FirstName = firstName
            };

            // Assert

            Assert.True(firstName == user.FirstName);

        }

        [Fact]
        public void Assert_User_Model_Has_String_Last_Name_Property()
        {
            // Arrange

            string lastName = "smith";

            // Act
            User user = new User()
            {
                LastName = lastName
            };

            // Assert

            Assert.True(lastName == user.LastName);

        }

        [Fact]
        public void Assert_User_Model_Has_List_Of_String_Roles_Property()
        {
            // Arrange

            string role1 = Guid.NewGuid().ToString();
            string role2 = Guid.NewGuid().ToString();
            string role3 = Guid.NewGuid().ToString();

            // Act
            User user = new User();
            user.Roles.Add(role1);
            user.Roles.Add(role2);

            // Assert

            Assert.True(role1 == user.Roles[0]);
            Assert.True(role2 == user.Roles[1]);

        }

    }
}

