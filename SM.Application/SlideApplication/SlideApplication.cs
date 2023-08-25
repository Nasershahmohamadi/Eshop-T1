using Framework.Application;
using SM.Applicationcontracts.Slide;
using SM.Domain.SlideAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.SlideApplication
{
    public class SlideApplication : ISlideApplication
    {
        private readonly ISlideRepository _slideRepository;

        public SlideApplication(ISlideRepository slideRepository)
        {
            _slideRepository = slideRepository;
        }

        public OperationResult Create(CreateSlideVM command)
        {
            var _operation = new OperationResult();
            try
            {
            var model = new Slide(command.Picture, command.PictureAlt, command.Title, command.Heading, command.Title, 
                command.Text, command.BtnText, command.Link);
            _slideRepository.Create(model);
                return _operation.Success();

            }
            catch (Exception)
            {

                return _operation.Failed();
            }
        }

        public OperationResult Delete(long id)
        {
            var _operation = new OperationResult();
            try
            {
                _slideRepository.Delete(id);
                return _operation.Success();
            }
            catch (Exception)
            {

                return _operation.Failed();
            }
        }

        public OperationResult Edit(EditeSlideVM command)
        {
            var _operation = new OperationResult();
            try
            {
                var entity =  _slideRepository.Get(command.Id);
                _slideRepository.Edit(entity);
                return _operation.Success();
            }
            catch (Exception)
            {

                return _operation.Failed();
            }
        }

        public EditeSlideVM Get(long id)
        {
            var item= _slideRepository.Get(id);
            return new EditeSlideVM
            {
                BtnText = item.BtnText,
                Heading = item.Heading,
                Id = item.Id,
                Link = item.Link,
                Picture = item.Picture,
                PictureAlt = item.PictureAlt,
                PictureTitle = item.PictureTitle,
                Text = item.Text,
                Title = item.Title

            };
        }

        public List<EditeSlideVM> Get()
        {
            var list = _slideRepository.Get();
            var _result = new List<EditeSlideVM>();
            foreach (var item in list)
            {
                _result.Add(new EditeSlideVM
                {
                    BtnText=item.BtnText,
                    Heading=item.Heading,
                    Id=item.Id,
                    Link=item.Link,
                    Picture=item.Picture,
                    PictureAlt=item.PictureAlt,
                    PictureTitle=item.PictureTitle,
                    Text=item.Text,
                    Title=item.Title
                });
            }
            return _result;
        }
    }
}
