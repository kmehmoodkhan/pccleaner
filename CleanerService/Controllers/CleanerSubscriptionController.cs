using CleanerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CleanerService.Controllers
{
    public class CleanerSubscriptionController : ApiController
    {
        private Business _BusinessLayer = null;
        public Business BusinessLayer
        {
            get
            {
                return _BusinessLayer;
            }
        }
        public CleanerSubscriptionController()
        {
            _BusinessLayer = new Business();
        }

        [HttpGet, Route("api/subscription/requestactivation")]
        public IHttpActionResult RequestActivation([FromUri]ClientInfo addSubscription)
        {
            try
            {
                BusinessLayer.RequestActivation(addSubscription.FullName, addSubscription.EmailAddress);
                return Ok(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Ok(HttpStatusCode.InternalServerError);
            }
        }


        [HttpGet, Route("api/subscription/addsubscription")]
        public IHttpActionResult AddSubscription([FromUri]ClientInfo addSubscription)
        {
            try
            {
                var result = BusinessLayer.AddSubscription(addSubscription.FullName, addSubscription.EmailAddress, addSubscription.MacId, addSubscription.ActivationCode);
                if (result.ErrorCode == 1)
                    return Ok(result);
                else
                    return Ok(HttpStatusCode.Conflict);
            }
            catch(Exception ex)
            {
                return Ok(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet, Route("api/subscription/isvalidsubscription")]
        public IHttpActionResult IsValidSubscription([FromUri]ClientInfo clientInfo)
        {
            try
            {
                var result = BusinessLayer.IsValidSubscription(clientInfo.FullName, clientInfo.EmailAddress, clientInfo.MacId, clientInfo.ActivationCode);
                if (result)
                {
                    return Ok(HttpStatusCode.OK);
                }
                else
                {
                    return Ok(HttpStatusCode.NotFound);
                }
            }
            catch(Exception ex)
            {
                return Ok(HttpStatusCode.InternalServerError);
            }
        }
    }
}
