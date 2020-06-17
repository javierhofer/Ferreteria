using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary
{
    class RepositorioCliente : IRepostory
    {
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetByID()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
        //propio del cliente...
        public void GetEspecific()
        {

        }
    }
    public interface IRepostory
    {
        void GetByID();
        void GetAll();
        void Insert();
        void Delete();
        void Update();

    }


}
