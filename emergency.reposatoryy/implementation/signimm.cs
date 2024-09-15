//using emergency.core;
//using emergency.reposatoryy.dbcontext;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace emergency.reposatoryy.implementation
//{
//    public class signimm : ISignup
//    {
//        public readonly appdbcontext context;

//        public signimm(appdbcontext _context)
//        {
//            context = _context;
//        }



//        async Task ISignup.writeuserdata(signup signup)
//        {
//            await context.AddAsync(signup);
//        }
//    }
//}