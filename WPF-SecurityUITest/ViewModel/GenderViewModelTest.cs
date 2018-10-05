using Entities;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WPF_SecurityUI.DataProvider;
using WPF_SecurityUI.ViewModel;
using Xunit;

namespace WPF_SecurityUITest.ViewModel
{
    public class GenderViewModelTest
    {
        private GenderViewModel _viewModel;

        public GenderViewModelTest()
        {
            var GenderDataProviderMock = new Mock<IDataProvider<Gender>>();
            GenderDataProviderMock.Setup(dp => dp.ReadAll())
                .Returns(new List<Gender>
                 {
                    new Gender { Id = 1, Title = "Male", DateIn = DateTime.Now, Dateupdate = DateTime.Now, MemberId = 1, Timestamp = null },
                    new Gender { Id = 2, Title = "Female", DateIn = DateTime.Now, Dateupdate = DateTime.Now, MemberId = 1, Timestamp = null }
                 }
                );
            _viewModel = new GenderViewModel(GenderDataProviderMock.Object);
        }
        [Fact]
        public void ShouldLoadGenders()
        {
            _viewModel.Load();

            Assert.Equal(2, _viewModel.Genders.Count);
        }

        [Fact]
        public void DuplicateGenderLoad()
        {
            _viewModel.Load();
            _viewModel.Load();
            Assert.Equal(2, _viewModel.Genders.Count);
            
        }

        [Fact]
        public void LoadSpecificGender()
        {
            _viewModel.Load();
            var Gender = _viewModel.Genders.SingleOrDefault(x => x.Id == 1);
            Assert.NotNull(Gender);
            Assert.Equal("Male", Gender.Title);

            Gender = _viewModel.Genders.SingleOrDefault(x => x.Id == 2);
            Assert.NotNull(Gender);
            Assert.Equal("Female", Gender.Title);
        }
    }
}
