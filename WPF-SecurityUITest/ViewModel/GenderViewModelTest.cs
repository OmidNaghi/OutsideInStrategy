using Entities;
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
        [Fact]
        public void ShouldLoadGenders()
        {
            var viewModel = new GenderViewModel(new GenderDataProviderMock());

            viewModel.Load();

            Assert.Equal(2, viewModel.Genders.Count);
        }

        [Fact]
        public void LoadSpecificGender()
        {
            var viewModel = new GenderViewModel(new GenderDataProviderMock());

            var Gender = viewModel.Genders.Single(x => x.Id==1);
            Assert.NotNull(Gender);


            Assert.Equal(2, viewModel.Genders.Count);
        }
    }

    public class GenderDataProviderMock : IDataProvider<Gender>
    {
        public bool Create(Gender entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Gender entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gender> ReadAll()
        {
            yield return new Gender { Id = 1, Title = "Male", DateIn = DateTime.Now, Dateupdate = DateTime.Now, MemberId = 1, Timestamp = null };
            yield return new Gender { Id = 2, Title = "Female", DateIn = DateTime.Now, Dateupdate = DateTime.Now, MemberId = 1, Timestamp = null };
            
        }

        public IEnumerable<Gender> ReadAll(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gender> ReadAll(Expression<Func<Gender, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Gender entity)
        {
            throw new NotImplementedException();
        }
    }
}
