using MediatR;
using Member.Application.Contracts.Persistance;
using Member.Infrastructure.Persistence;
using Member.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MemberContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DBConnectionString")));


            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IMemberRepository, TeamMemberRepository>();
            services.AddScoped<IMemberTaskRepository, TeamMemberTaskRepository>();
            return services;
        }
    }
}
