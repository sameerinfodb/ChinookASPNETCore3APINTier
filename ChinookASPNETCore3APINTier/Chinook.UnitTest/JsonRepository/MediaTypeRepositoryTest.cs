﻿using Chinook.DataEFCore.Repositories;
using Chinook.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Chinook.UnitTest.JsonRepository
{
    public class MediaTypeRepositoryTest
    {
        private readonly IMediaTypeRepository _repo;

        public MediaTypeRepositoryTest()
        {
            var services = new ServiceCollection();
            services.AddTransient<IMediaTypeRepository, MediaTypeRepository>();

            var serviceProvider = services.BuildServiceProvider();

            _repo = serviceProvider.GetService<IMediaTypeRepository>();
        }

        [Fact]
        public void MediaTypeGetAll()
        {
            // Act
            var mediaTypes = _repo.GetAll();

            // Assert
            Assert.True(mediaTypes.Count > 1, "The number of media types was not greater than 1");
        }
    }
}