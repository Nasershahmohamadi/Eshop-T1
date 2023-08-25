using Framework.Domain;
using Infrastructure.Context;
using SM.Domain.SlideAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain
{
    public class SlideRepository :RepositoryBase<long, Slide> , ISlideRepository
    {
        private readonly eShopContext _context;

        public SlideRepository(eShopContext context) : base(context)
        {
            _context = context;
        }

        public bool Delete(long id)
        {
            try
            {
                Get(id).Delete();
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Edit(Slide command)
        {
            try
            {
                Get(command.Id).Edit(command.Picture, command.PictureAlt, command.Title, command.Heading, command.Title,
                    command.Text, command.BtnText, command.Link);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
