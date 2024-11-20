using FastEndpoints;
using useMeBE.Data;
using useMeBE.Models;

namespace useMeBE.Endpoints
{
    public class Login 
    {
        public class MyRequest
        { 
            public string UserName { get; set; }
            public string Password { get; set; }
  
        }
        public class MyResponse
        {
            public int Id { get; set; }
            public string UserName { get; set; }
        }

        public class MyEndpoint : Endpoint<MyRequest, MyResponse>
        {
            private readonly TestDbContext dbContext;

            public MyEndpoint(TestDbContext dbContext)
            {
                this.dbContext = dbContext;
            }
            public override void Configure()
            {
                Post("/api/user/login");
                AllowAnonymous();
            }



            public override async Task HandleAsync(MyRequest req, CancellationToken ct)
            {

                var user = dbContext.Users.Where(x => x.UserName == req.UserName).FirstOrDefault();
                if (user == null)
                {
                    await SendUnauthorizedAsync();
                    return;
                }

                if (string.IsNullOrEmpty(req.Password))
                {
                    AddError("nhap sai mat khau");
                    await SendErrorsAsync();
                    return;
                }

                if(req.Password != user.Password) {
                    await SendUnauthorizedAsync();
                    return;
                }

                await SendAsync(new()
                {
                    Id = user.Id,
                    UserName = user.UserName
                }) ;
            }
        }
    }
}
