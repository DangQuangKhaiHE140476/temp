using QLHSC07.Entity.QLHSC07_MSG_Entities;
using QLHSC07.Model.BaseModels;
using QLHSC07.Model.DocumentUpload;
using System;
using System.Collections.Generic;

namespace QLHSC07.Model.QLHSC07_Dtos.MsgExchange
{
    public class ExchangeMsgDto
    {
        public MsgSession MsgSession { get; set; }
        public Message Message { get; set; }
        public MsgReceive MsgReceives { get; set; }
        public HasMsgSession HasMsgSession { get; set; }
        public long? MsgReceivesPC07Id { get; set; }
        public string MsgReceivesPC07Name { get; set; }
        public long? MsgSenderPC07Id { get; set; }
        public string MsgSenderPC07Name { get; set; }
        public MessageHasFile MessageHasFile { get; set; }
        public FileDetailDto DocumentUpload { get; set; }
    }
    public class MsgSessionDictDto
    {
        public string Key { get; set; }
        public MsgSessionDto MsgSession { get; set; }
        public int ReplyNumber { get; set; }
        public string ReceiveUsers { get; set; }
        public ICollection<SenderReceivePersonDto> ReceiveUserDetail { get; set; }
        public ICollection<FileDetailDto> FilesAttachs { get; set; }

    }
    public class ReplyMessageDto
    {
        public string Session { get; set; }
        public string Message { get; set; }
    }

    public class SenderReceivePersonDto
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Session { get; set; }
    }

    public class MsgSessionDto : FullAuditedEntityDto<string>
    {
        public long? MessageId { get; set; }
        public SenderReceivePersonDto LocalSendPlace { get; set; }
        public string Title { get; set; }
        public string MsgSessionId { get; set; }
        public string Content { get; set; }
        public bool? IsReply { get; set; }
        public DateTime? MessageDate { get; set; }
        public long? MessageById { get; set; }
        public bool? IsImportant { get; set; }
        public long? MsgReceivesPC07Id { get; set; }
        public string MsgReceivesPC07Name { get; set; }

    }

    public class MessageDto
    {
        public long? MessageId { get; set; }
        public MessageDetailDto MessageDetail { get; set; }
        public List<FileDetailDto> FilesAttachs { get; set; }
    }
    public class MessageDetailDto
    {
        public string MsgSessionId { get; set; }
        public string Content { get; set; }
        public bool? IsReply { get; set; }
        public DateTime? MessageDate { get; set; }
        public long? MessageById { get; set; }
        public bool? IsImportant { get; set; }
        public SenderReceivePersonDto PcLocalReply { get; set; }
    }


    public class MsgReceivesDto
    {
        public long MsgReceivesPC07Name { get; set; }
    }
}
