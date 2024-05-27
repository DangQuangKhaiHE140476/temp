using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Data.Interfaces;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Model;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using SwiftExcel;
using Microsoft.EntityFrameworkCore;
using QLHSC07.CORE;

namespace QLHSC07.ApiGateway.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExportDataController : ControllerBase
    {
        private readonly IHostEnvironment _env;
        private readonly IFormTemplateQuestionRepository _formTemplateQuestionRepository;
        private readonly IPersonInfoAnswerRepository _personInfoAnswerRepository;

        public ExportDataController(IHostEnvironment env,
            IFormTemplateQuestionRepository formTemplateQuestionRepository,
            IPersonInfoAnswerRepository personInfoAnswerRepository)
        {
            _env = env;
            _formTemplateQuestionRepository = formTemplateQuestionRepository;
            _personInfoAnswerRepository = personInfoAnswerRepository;
        }

        [HttpPost]
        [ActionName("ExportExcel")]
        public ActionResult ExportExcel([FromBody] string jsonData)
        {
            var fileName = "Data Export " + DateTime.Now;
            fileName = fileName.Replace(":", "-");
            var pathFolder = Path.Combine(_env.ContentRootPath, "Excel Data");
            if (!Directory.Exists(pathFolder))
            {
                Directory.CreateDirectory(pathFolder);
            }

            if (Directory.GetFiles(pathFolder).Length > 30)
            {
                Directory.Delete(pathFolder);
                Directory.CreateDirectory(pathFolder);
            }

            var pathFile = Path.Combine(pathFolder, fileName) + ".xlsx";
            var parserData = new ParserData();
            JsonConvert.PopulateObject(jsonData, parserData);
            var sheet = new Sheet
            {
                Name = "Sheet 1",
                ColumnsWidth = new List<double> {20, 20, 20, 20, 30}
            };
            using (var report = new ExcelWriter(pathFile, sheet))
            {
                for (var column = 0; column < parserData.headerTable.Count; column++)
                {
                    report.Write(
                        !string.IsNullOrEmpty(parserData.headerTable[column].alias)
                            ? parserData.headerTable[column].alias
                            : " ", column + 1, 1);
                }

                for (var row = 0; row < parserData.data.Count; row++)
                {
                    report.Write(
                        !string.IsNullOrEmpty(parserData.data[row].layer)
                            ? parserData.data[row].layer
                            : " ", 1, row + 2);
                    report.Write(
                        !string.IsNullOrEmpty(parserData.data[row].dientich)
                            ? parserData.data[row].dientich
                            : " ", 2, row + 2, DataType.Number);
                    report.Write(
                        !string.IsNullOrEmpty(parserData.data[row].matdo)
                            ? parserData.data[row].matdo
                            : " ", 3, row + 2, DataType.Number);
                    report.Write(
                        !string.IsNullOrEmpty(parserData.data[row].tangcao)
                            ? parserData.data[row].tangcao
                            : " ", 4, row + 2, DataType.Number);
                    report.Write(
                        !string.IsNullOrEmpty(parserData.data[row].ten_loai_dat)
                            ? parserData.data[row].ten_loai_dat
                            : " ", 5, row + 2);
                }

                report.Save();
            }

            if (!System.IO.File.Exists(pathFile))
                return BadRequest(new ResponseErrorData
                {
                    ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
                    ErrorType = ErrorTypeConstant.ErrorProcess
                });
            var byteArray = System.IO.File.ReadAllBytes(pathFile);
            return File(byteArray, "application/octet-stream", fileName + ".xlsx");
        }

        //[HttpPost]
        //[ActionName("ExportConsultantList")]
        //public ActionResult ExportConsultantList(int templateId, int pageIndex, int pageSize)
        //{
        //    var fileName = "Consultant Community Export " + DateTime.Now;
        //    fileName = fileName.Replace(":", "-");
        //    var pathFolder = Path.Combine(_env.ContentRootPath, "Excel Data");
        //    if (!Directory.Exists(pathFolder))
        //    {
        //        Directory.CreateDirectory(pathFolder);
        //    }

        //    if (Directory.GetFiles(pathFolder).Length > 30)
        //    {
        //        Directory.Delete(pathFolder);
        //        Directory.CreateDirectory(pathFolder);
        //    }

        //    var pathFile = Path.Combine(pathFolder, fileName) + ".xlsx";
        //    var questions = _formTemplateQuestionRepository.Query(x => x.FormTemplateId == templateId)
        //        .Include(x => x.Answers).ToList();
        //    var answers = _personInfoAnswerRepository.Query(x => x.TemplateId == templateId)
        //        .Include(x => x.Answers).ToList();
        //    var result = new DetailFeedbackDto
        //    {
        //        FormTemplateId = templateId,

        //        Questions = questions.Select(x => new Question()
        //        {
        //            Id = x.Id,
        //            Title = x.Title,
        //            HaveAdditional = x.HaveAdditional,
        //            Answers = x.Answers.Select(a => new Answer()
        //            {
        //                Id = a.Id,
        //                Order = a.Order,
        //                Title = a.Title
        //            }).OrderBy(a => a.Order).ToList()
        //        }).OrderBy(x => x.Order).ToList(),

        //        UserAnswers = answers.Select(x => new UserAnswer()
        //            {
        //                PersonId = x.Id,
        //                Name = x.Name,
        //                PhoneNo = x.PhoneNo,
        //                Email = x.Email,
        //                Address = x.Address,
        //                Suggestion = x.Suggestion,
        //                Reply = x.Reply, // add reply
        //                Answers = x.Answers.Select(a => new PersonAnswer()
        //                {
        //                    QuestionId = a.QuestionId,
        //                    AnswerId = a.AnswerId,
        //                    Additions = a.Additional
        //                }).ToList()
        //            }).AsQueryable()
        //            .ToPagedList(pageIndex, pageSize)
        //    };
        //    var colWid = new List<double> {25, 30, 25, 30};
        //    foreach (var question in result.Questions)
        //    {
        //        foreach (var answer in question.Answers)
        //        {
        //            colWid.Add(20);
        //        }

        //        if (question.HaveAdditional) colWid.Add(30);
        //    }

        //    colWid.Add(50);
        //    var sheet = new Sheet
        //    {
        //        Name = "Sheet 1",
        //        ColumnsWidth = colWid
        //    };
        //    using (var report = new ExcelWriter(pathFile, sheet))
        //    {
        //        var userInfor = new List<string>
        //        {
        //            "Họ và tên",
        //            "Địa chỉ",
        //            "Số điện thoại",
        //            "Email"
        //        };
        //        var questionColIndex = userInfor.Count + 1;
        //        var ansQuestionColIndex = questionColIndex;
        //        var columnMatrix = new Dictionary<int, int>();
        //        foreach (var question in result.Questions)
        //        {
        //            report.Write(question.Title, questionColIndex, 1);
        //            questionColIndex += question.Answers.Count;
        //            if (question.HaveAdditional) questionColIndex++;
        //        }

        //        report.Write("Ý kiến phản hồi", questionColIndex, 1);
        //        for (var i = 0; i < userInfor.Count; i++)
        //        {
        //            report.Write(userInfor[i], i + 1, 2);
        //        }

        //        foreach (var question in result.Questions)
        //        {
        //            foreach (var ansQues in question.Answers)
        //            {
        //                report.Write(ansQues.Title, ansQuestionColIndex, 2);
        //                columnMatrix.Add((int) ansQues.Id, ansQuestionColIndex);
        //                ansQuestionColIndex++;
        //            }

        //            if (!question.HaveAdditional) continue;
        //            report.Write("Ý kiến khác", ansQuestionColIndex, 2);
        //            ansQuestionColIndex++;
        //        }

        //        //write body
        //        var entryIndex = 3;
        //        foreach (var entry in result.UserAnswers.Items)
        //        {
        //            report.Write(entry.Name, 1, entryIndex);
        //            report.Write(entry.Address, 2, entryIndex);
        //            report.Write(entry.PhoneNo, 3, entryIndex);
        //            report.Write(entry.Email, 4, entryIndex);
        //            foreach (var answer in entry.Answers)
        //            {
        //                report.Write("✔", columnMatrix.FirstOrDefault(x => x.Key == answer.AnswerId).Value, entryIndex);
        //            }
        //            report.Write(entry.Reply,questionColIndex,entryIndex);
        //            entryIndex++;
        //        }

        //        report.Save();
        //    }

        //    if (!System.IO.File.Exists(pathFile))
        //        return BadRequest(new ResponseErrorData
        //        {
        //            ErrorMessage = StringMessage.ErrorMessages.ErrorProcess,
        //            ErrorType = ErrorTypeConstant.ErrorProcess
        //        });
        //    var byteArray = System.IO.File.ReadAllBytes(pathFile);
        //    return File(byteArray, "application/octet-stream", fileName + ".xlsx");
        //}
    }

    #region MapModel

    public class ParserData
    {
        public List<Row> data { get; set; }
        public List<Column> headerTable { get; set; }
    }

    public class Row
    {
        public string layer { get; set; }
        public string dientich { get; set; }
        public string matdo { get; set; }
        public string tangcao { get; set; }
        public string ten_loai_dat { get; set; }
    }

    public class Column
    {
        public string alias { get; set; }
    }

    #endregion
}
    