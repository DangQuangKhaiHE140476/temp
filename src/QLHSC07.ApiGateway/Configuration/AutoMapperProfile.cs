using AutoMapper;
using QLHSC07.Dto.BaseEntity;
using QLHSC07.Entity;
using QLHSC07.Entity.Administrative;
using QLHSC07.Entity.ConsultCommunity;
using QLHSC07.Entity.CRM;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.LogHistory;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Entity.QLHSC07_MSG_Entities;
using QLHSC07.Entity.SecurityMatrix;
using QLHSC07.Model;
using QLHSC07.Model.Commune;
using QLHSC07.Model.CRM.Client;
using QLHSC07.Model.CRM.ClientNote;
using QLHSC07.Model.CRM.DepositHistory;
using QLHSC07.Model.CRM.Order;
using QLHSC07.Model.CRM.Plan;
using QLHSC07.Model.District;
using QLHSC07.Model.Document;
using QLHSC07.Model.DocumentUpload;
using QLHSC07.Model.EmailGenerated;
using QLHSC07.Model.LogHistory;
using QLHSC07.Model.Province;
using QLHSC07.Model.QLHSC07_Dtos.AttachFileType;
using QLHSC07.Model.QLHSC07_Dtos.DocumentAnsType;
using QLHSC07.Model.QLHSC07_Dtos.Investors;
using QLHSC07.Model.QLHSC07_Dtos.MsgExchange;
using QLHSC07.Model.QLHSC07_Dtos.PC07;
using QLHSC07.Model.QLHSC07_Dtos.ProjectGroup;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Model.QLHSC07_Dtos.ProjectStatus;
using QLHSC07.Model.QLHSC07_Dtos.ProjectType;
using QLHSC07.Model.QLHSC07_Dtos.Rank;
using QLHSC07.Model.QLHSC07_Dtos.ReceiveType;
using QLHSC07.Model.QLHSC07_Dtos.Records;
using QLHSC07.Model.QLHSC07_Dtos.RecordsFiles;
using QLHSC07.Model.QLHSC07_Dtos.RecordsResultProcessings;
using QLHSC07.Model.QLHSC07_Dtos.RecordsStatus;
using QLHSC07.Model.QLHSC07_Dtos.RecordTypes;
using QLHSC07.Model.QLHSC07_Dtos.Regency;
using QLHSC07.Model.Role;
using QLHSC07.Model.SecurityMatrix;
using System.Collections.Generic;

namespace QLHSC07.ApiGateway.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region core mapping
            CreateMap<EmailGenerated, EmailGeneratedDetailDto>();
            CreateMap<EmailGenerated, EmailGeneratedViewDto>();

            CreateMap<CreateEmailGeneratedDto, EmailGenerated>();

            //Role 
            CreateMap<Role, RoleViewDto>();
            CreateMap<Role, RoleLookupDto>();
            CreateMap<CreateRoleDto, Role>();
            CreateMap<UpdateRoleDto, Role>();

            //Security Matrix
            CreateMap<SecurityMatrix, ActionLookupDto>();
            CreateMap<Entity.SecurityMatrix.Screen, ScreenDto>();

            //Administrative
            CreateMap<Province, ProvinceViewDto>();
            CreateMap<CreateProvinceDto, Province>();
            CreateMap<District, DistrictViewDto>();
            CreateMap<CreateDistrictDto, District>();
            CreateMap<Commune, CommuneViewDto>()
                .ForMember(dest => dest.DistrictName, opt => opt.MapFrom(x => x.District != null ? x.District.Name : ""))
                .ForMember(dest => dest.ProvinceName, opt => opt.MapFrom(x => x.District != null && x.District.Province != null ? x.District.Province.Name : ""))
                .ForMember(dest => dest.ProvinceId, opt => opt.MapFrom(x => x.District != null ? x.District.ProvinceId : 0));
            CreateMap<CreateCommuneDto, Commune>();
            //FormTemplate
            //CreateMap<FormTemplate, FormTemplateModel>();
            //CreateMap<FormTemplate, FormExampleLookup>();

            //LogHistory
            CreateMap<LogHistoryDto, LogHistoryEntity>();
            CreateMap<LogHistoryEntity, LogHistoryDto>();

            //DocumentUpload
            CreateMap<DocumentUploadDto, DocumentUpload>();
            CreateMap<DocumentUpload, DocumentDetailDto>();
            CreateMap<DocumentDetailDto, DocumentUpload>();
            CreateMap<DocumentUpload, DocumentViewModel>();
            CreateMap<DocumentUpload, Files>()
                .ForMember(dest => dest.fileId, opt => opt.MapFrom(source => source.Id == 0 ? 0 : source.Id))
                .ForMember(dest => dest.fileName, opt => opt.MapFrom(source => string.IsNullOrEmpty(source.Name) ? string.Empty : source.Name))
                .ForMember(dest => dest.filePreview, opt => opt.MapFrom(source => string.IsNullOrEmpty(source.Path) ? string.Empty : source.Path))
                .ForMember(dest => dest.fileType, opt => opt.MapFrom(source => source.Type == 0 ? 0 : source.Type));

            //Document
            CreateMap<Project, ProjectDto>()
               .ForMember(dest => dest.Positions, opt => opt.MapFrom(source => source.ProjectHasCommunes != null ? TryParsePosition(source.ProjectHasCommunes) : null))
               //.ForMember(dest => dest.ConstructionTypeName, opt => opt.MapFrom(source => source.ConstructionTypes != null ? source.ConstructionTypes.Name : ""))
               .ForMember(dest => dest.ProjectGroupName, opt => opt.MapFrom(source => source.ProjectGroup != null ? source.ProjectGroup.Name : ""))
               .ForMember(dest => dest.ProjectStatusName, opt => opt.MapFrom(source => source.ProjectStatus != null ? source.ProjectStatus.Name : ""))
               .ForMember(dest => dest.ProjectHasCommuneId, opt => opt.MapFrom(source => source.ProjectHasCommunes != null ? GetCommuneId(source.ProjectHasCommunes)  : null))
               .ForMember(dest => dest.ProjectTypeName, opt => opt.MapFrom(source => source.ProjectType != null ? source.ProjectType.Name : ""));

            #endregion
            ///Project
            CreateMap<CreateRegencyDto, Regency>().ReverseMap();
            CreateMap<UpdateRegencyDto, Regency>().ReverseMap();
            CreateMap<RegencyDto, Regency>().ReverseMap();

            CreateMap<CreateRankDto, Rank>().ReverseMap();
            CreateMap<UpdateRankDto, Rank>().ReverseMap();
            CreateMap<RankDto, Rank>().ReverseMap();

            CreateMap<CreateReceiveTypeDto, ReceiveType>().ReverseMap();
            CreateMap<UpdateReceiveTypeDto, ReceiveType>().ReverseMap();
            CreateMap<ReceiveTypeDto, ReceiveType>().ReverseMap();

            CreateMap<CreateRecordsDto, Records>().ReverseMap();
            CreateMap<UpdateRecordsDto, Records>().ReverseMap();
            CreateMap<RecordsDto, Records>().ReverseMap();

            CreateMap<CreateRecordsStatusDto, RecordsStatus>().ReverseMap();
            CreateMap<UpdateRecordsStatusDto, RecordsStatus>().ReverseMap();
            CreateMap<RecordsStatusDto, RecordsStatus>().ReverseMap();

            CreateMap<CreateRecordTypesDto, RecordsType>().ReverseMap();
            CreateMap<UpdateRecordTypesDto, RecordsType>().ReverseMap();
            CreateMap<RecordTypesDto, RecordsType>().ReverseMap();

            CreateMap<CreateProjectTypeDto, ProjectType>().ReverseMap();
            CreateMap<UpdateProjectTypeDto, ProjectType>().ReverseMap();
            CreateMap<ProjectTypeDto, ProjectType>().ReverseMap();

            CreateMap<CreateProjectStatusDto, ProjectStatus>().ReverseMap();
            CreateMap<UpdateProjectStatusDto, ProjectStatus>().ReverseMap();
            CreateMap<ProjectStatusDto, ProjectStatus>().ReverseMap();

            CreateMap<CreateProjectDto, Project>().ReverseMap();
            CreateMap<UpdateProjectDto, Project>().ReverseMap();
            CreateMap<ProjectDto, Project>();

            CreateMap<CreateProjectGroupDto, ProjectGroup>().ReverseMap();
            CreateMap<UpdateProjectGroupDto, ProjectGroup>().ReverseMap();
            CreateMap<ProjectGroupDto, ProjectGroup>().ReverseMap();

            CreateMap<CreatePC07Dto, PC07Local>().ReverseMap();
            CreateMap<UpdatePC07Dto, PC07Local>().ReverseMap();
            CreateMap<PC07Local, PC07Dto>()
                .ForMember(des => des.ProvinceName, opt => opt.MapFrom(source => source.Province.Name))
                .ForMember(des => des.CommuneName, opt => opt.MapFrom(source => source.Commune.Name))
                .ForMember(des => des.DistrictId, opt => opt.MapFrom(source => source.Commune.DistrictId))
                .ForMember(des => des.DistrictName, opt => opt.MapFrom(source => source.Commune.District.Name));

            CreateMap<CreateMsgExchange, MsgSession>().ReverseMap();
            CreateMap<UpdateMsgExchangeDto, MsgSession>().ReverseMap();
            CreateMap<ExchangeMsgDto, MsgSession>().ReverseMap();

            CreateMap<CreateInvestorDto, Investor>().ReverseMap();
            CreateMap<UpdateInvestorDto, Investor>().ReverseMap();
            CreateMap<InvestorDto, Investor>();
            CreateMap<Investor, InvestorDto>()
                  .ForMember(dest => dest.ProvinceId, opt => opt.MapFrom(source => source.ProvinceId))
                  .ForMember(dest => dest.ProvinceName, opt => opt.MapFrom(source => source.Province != null ? source.Province.Name : ""))
                  .ForMember(dest => dest.DistrictId, opt => opt.MapFrom(source => source.DistrictId))
                  .ForMember(dest => dest.DistrictName, opt => opt.MapFrom(source => source.District != null ? source.District.Name : ""))
                  .ForMember(dest => dest.CommuneId, opt => opt.MapFrom(source => source.CommuneId))
                  .ForMember(dest => dest.CommuneName, opt => opt.MapFrom(source => source.Commune != null ? source.Commune.Name : ""));

            CreateMap<CreateAttachFileTypeDto, FileTypeAttachment>().ReverseMap();
            CreateMap<UpdateAttachFileTypeDto, FileTypeAttachment>().ReverseMap();
            CreateMap<AttachFileTypeDto, FileTypeAttachment>().ReverseMap();

            CreateMap<CreateDocumentAnsTypeDto, DocumentAnsType>().ReverseMap();
            CreateMap<UpdateDocumentAnsTypeDto, DocumentAnsType>().ReverseMap();
            CreateMap<DocumentAnsTypeDto, DocumentAnsType>().ReverseMap();


            ///mapper dto record
            CreateMap<RecordsFile, RecordsFileDto>()
                  .ForMember(dest => dest.Path, opt => opt.MapFrom(source => (source.DocumentUpload == null) ? "" : source.DocumentUpload.Path))
                  .ForMember(dest => dest.FileTypeAttachmentName, opt => opt.MapFrom(source => (source.FileTypeAttachment == null) ? "" : source.FileTypeAttachment.Name));
            CreateMap<Records, RecordsDto>()
                  .ForMember(dest => dest.ProjectsInvestorName, opt => opt.MapFrom(source => (source.Projects == null || source.Projects.Investors == null) ? "" : source.Projects.Investors.Name))
                  .ForMember(dest => dest.ProjectsProjectTypeName, opt => opt.MapFrom(source => (source.Projects == null || source.Projects.ProjectType == null) ? "" : source.Projects.ProjectType.Name))
                  .ForMember(dest => dest.ProjectsProjectGroupName, opt => opt.MapFrom(source => (source.Projects == null || source.Projects.ProjectGroup == null) ? "" : source.Projects.ProjectGroup.Name))
                  .ForMember(dest => dest.ProjectsProjectStatusName, opt => opt.MapFrom(source => (source.Projects == null || source.Projects.ProjectStatus == null) ? "" : source.Projects.ProjectStatus.Name))
                  .ForMember(dest => dest.RecordsTypeName, opt => opt.MapFrom(source => source.RecordsTypes != null ? source.RecordsTypes.Name : ""))
                  .ForMember(dest => dest.PC07ManageName, opt => opt.MapFrom(source => source.PC07Manage != null ? source.PC07Manage.Name : ""))
                  .ForMember(dest => dest.PC07ReceiveName, opt => opt.MapFrom(source => source.PC07Receive != null ? source.PC07Receive.Name : ""))
                  .ForMember(dest => dest.ReceiveTypeName, opt => opt.MapFrom(source => source.ReceiveTypes != null ? source.ReceiveTypes.Name : ""))
                  .ForMember(dest => dest.DocumentTypeId, opt => opt.MapFrom(source => source.DocumentAnsTypeId))
                  .ForMember(dest => dest.ProjectsProjectStatusId, opt => opt.MapFrom(source => (source.Projects == null) ? 0 : source.Projects.ProjectStatusId))
                  .ForMember(dest => dest.ProjectsProjectStatusName, opt => opt.MapFrom(source => (source.Projects == null || source.Projects.ProjectStatus == null) ? "" : source.Projects.ProjectStatus.Name))
                  .ForMember(dest => dest.Positions, opt => opt.MapFrom(source => (source.Projects == null
                                                                              || source.Projects.ProjectHasCommunes == null ? null : TryParsePosition(source.Projects.ProjectHasCommunes))))
                  .ForMember(dest => dest.ProjectCommuneIds, opt => opt.MapFrom(source => (source.Projects != null && source.Projects.ProjectHasCommunes != null) ? GetCommuneId(source.Projects.ProjectHasCommunes) : null))
                  .ForMember(dest => dest.DocumentAnsTypeName, opt => opt.MapFrom(source => source.DocumentAnsType == null ? "" : source.DocumentAnsType.Name))
                  .ForMember(dest => dest.PC07ManageProvinceId, opt => opt.MapFrom(source => (source.PC07Manage == null) ? 0 : source.PC07Manage.ProvinceId))
                  .ForMember(dest => dest.RecordsStatuName, opt => opt.MapFrom(source => source.RecordsStatus != null ? source.RecordsStatus.Name : ""));

            CreateMap<CreateRecordsResultProcessingDto, RecordsResultProcessing>().ReverseMap();
            CreateMap<UpdateRecordsResultProcessingDto, RecordsResultProcessing>();
            CreateMap<RecordsResultProcessing, RecordsResultProcessingDto>()
                .ForMember(des => des.TenTepTin, opt => opt.MapFrom(source => source.DocumentUpload.Name))
                .ForMember(des => des.KieuDinhDang, opt => opt.MapFrom(source => source.DocumentUpload.FileExtension!=null ? source.DocumentUpload.FileExtension.Name : ""))
                .ForMember(des => des.DocumentUploadPath, opt => opt.MapFrom(source => source.DocumentUpload!=null ? source.DocumentUpload.Path : ""));


            CreateMap<CreateClientDto, Client>().ReverseMap();
            CreateMap<UpdateClientDto, Client>().ReverseMap();
            CreateMap<ClientViewDto, Client>().ReverseMap();


            CreateMap<CreateClientNoteDto, ClientNote>().ReverseMap();
            CreateMap<UpdateClientNoteDto, ClientNote>().ReverseMap();
            CreateMap<ClientNoteViewDto, ClientNote>().ReverseMap();

            CreateMap<CreateDepositHistoryDto, DepositHistory>().ReverseMap();
            CreateMap<UpdateDepositHistoryDto, DepositHistory>().ReverseMap();
            CreateMap<DepositHistoryViewDto, DepositHistory>().ReverseMap();

            CreateMap<CreateOrderDto, Order>().ReverseMap();
            CreateMap<UpdateOrderDto, Order>().ReverseMap();
            CreateMap<OrderViewDto, Order>().ReverseMap();

            CreateMap<CreatePlanDto, Plan>().ReverseMap();
            CreateMap<UpdatePlanDto, Plan>().ReverseMap();
            CreateMap<PlanViewDto, Plan>().ReverseMap();
        }
        public List<Positions> TryParsePosition(ICollection<ProjectHasCommune> projectHasCommunes)
        {
            var lst = new List<Positions>();
            List<ProjectHasCommune> dataCommunes = new List<ProjectHasCommune>(projectHasCommunes);
            dataCommunes.ForEach(x =>
            {
                if (x.CommuneId != 0)
                {
                    lst.Add(new Positions()
                    { 
                        Commune = new PositionKeyValue()
                        {
                            Id = x.CommuneId,
                            Value = x.Commune?.Name
                        },
                        District = new PositionKeyValue()
                        {
                            Id = x.Commune?.DistrictId,
                            Value = x.Commune?.GetDistrictName()
                        },
                        Province = new PositionKeyValue()
                        {
                            Id = x.Commune?.District?.ProvinceId,
                            Value = x.Commune?.District?.GetProvinceName()
                        }
                    });
                }
            });
            return lst;
        }

        public List<int> GetCommuneId(ICollection<ProjectHasCommune> projectHasCommunes)
        {
            var lst = new List<int>();
            List<ProjectHasCommune> dataCommunes = new List<ProjectHasCommune>(projectHasCommunes);
            dataCommunes.ForEach(x =>
            {
                if (x.CommuneId != 0)
                {
                    lst.Add(x.CommuneId);
                }
            });
            return lst;
        }
    }
}
