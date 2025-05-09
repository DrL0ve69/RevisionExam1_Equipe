using Microsoft.AspNetCore.Mvc;
using RevisionExam1_Equipe.Controllers;

namespace Test_ProjetLivre_Equipe
{
    public class Test_LivreController
    {
        [Fact]
        public void Test_TypeRetour_Catalogue()
        {
            // Arrange
            var controller = new LivreController();
            // Act
            var result = controller.Catalogue();
            // Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Test_TypeRetour_TrouverLivre()
        {
            // Arrange
            var controller = new LivreController();
            // Act
            var result = controller.TrouverLivre(1);
            // Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Test_TypeRetour_Introuvable()
        {
            // Arrange
            var controller = new LivreController();
            // Act
            var result = controller.TrouverLivre(111);
            // Assert
            Assert.IsType<ContentResult>(result);
        }
    }
}
