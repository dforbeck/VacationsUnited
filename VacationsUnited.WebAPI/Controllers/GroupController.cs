﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using VacationsUnited.Models.Group.models;
using VacationsUnited.Services;

namespace VacationsUnited.WebAPI.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]
    public class GroupController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            GroupService groupService = CreateGroupService();
            var groups = groupService.GetGroups();
            return Ok(groups);
        }

        private GroupService CreateGroupService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var groupService = new GroupService(userId);
            return groupService;
        }

        public IHttpActionResult Get(int id)
        {
            GroupService groupService = CreateGroupService();
            var group = groupService.GetGroupByID(id);
            return Ok();
        }

        public IHttpActionResult Post(GroupCreate group)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateGroupService();

            if (!service.CreateGroup(group))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Put(GroupEdit group)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateGroupService();

            if (!service.EditGroup(group))
                return InternalServerError();
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateGroupService();

            if (!service.DeleteGroup(id))
                return InternalServerError();

            return Ok();
        }

    }
}
