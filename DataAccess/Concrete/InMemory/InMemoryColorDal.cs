using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IEntityRepository<Color>
    {
        List<Color> _Colors;

        public InMemoryColorDal()
        {
            _Colors = new List<Color>
            {
                new Color(){ColorId=1,ColorName="Black"},
                new Color(){ColorId=2,ColorName="White"},
                new Color(){ColorId=3,ColorName="Red"},
                new Color(){ColorId=4,ColorName="Blue"},
                new Color(){ColorId=5,ColorName="Yellow"},
                new Color(){ColorId=6,ColorName="Gray"},
            };
        }

        public void Add(Color color)
        {
            _Colors.Add(color);
        }

        public void Delete(Color color)
        {
            _Colors.Remove(_Colors.SingleOrDefault(c => c.ColorId == color.ColorId));
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _Colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            colorToUpdate.ColorId = color.ColorId;
            colorToUpdate.ColorName = color.ColorName;
        }

        public Color get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return _Colors;
        }

    }
}
