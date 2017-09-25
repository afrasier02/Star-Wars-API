using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Api_Integration.Tests
{
    /// <summary>
    ///
    /// </summary>
    [TestFixture]
    public class CharacterTests
    {
        private GetStarWarsCharactersService _service;
        private string _url = "https://swapi.co/api/people";

        /// <summary>
        ///
        /// </summary>
        [SetUp]
        public void Init()
        {
            _service = new GetStarWarsCharactersService(_url);
        }

        /// <summary>
        ///
        /// </summary>
        [Test]
        public void Service_InitialTest()
        {
            var response = _service.GetStarWarsCharacters();

            Assert.Greater(Convert.ToInt32(response.count), 0);
        }
    }
}
