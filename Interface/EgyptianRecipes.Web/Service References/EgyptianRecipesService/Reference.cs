﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EgyptianRecipes.Web.EgyptianRecipesService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EgyptianRecipesService.IEgyptianRecipesService")]
    public interface IEgyptianRecipesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgyptianRecipesService/ValidateBranch", ReplyAction="http://tempuri.org/IEgyptianRecipesService/ValidateBranchResponse")]
        EgyptianRecipes.Web.EgyptianRecipesService.ValidateBranchResponse ValidateBranch(EgyptianRecipes.Web.EgyptianRecipesService.ValidateBranchRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgyptianRecipesService/ValidateBranch", ReplyAction="http://tempuri.org/IEgyptianRecipesService/ValidateBranchResponse")]
        System.Threading.Tasks.Task<EgyptianRecipes.Web.EgyptianRecipesService.ValidateBranchResponse> ValidateBranchAsync(EgyptianRecipes.Web.EgyptianRecipesService.ValidateBranchRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgyptianRecipesService/GetAllBranches", ReplyAction="http://tempuri.org/IEgyptianRecipesService/GetAllBranchesResponse")]
        EgyptianRecipes.Entities.Branch[] GetAllBranches();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgyptianRecipesService/GetAllBranches", ReplyAction="http://tempuri.org/IEgyptianRecipesService/GetAllBranchesResponse")]
        System.Threading.Tasks.Task<EgyptianRecipes.Entities.Branch[]> GetAllBranchesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgyptianRecipesService/GetBranchesByID", ReplyAction="http://tempuri.org/IEgyptianRecipesService/GetBranchesByIDResponse")]
        EgyptianRecipes.Entities.Branch GetBranchesByID(long ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgyptianRecipesService/GetBranchesByID", ReplyAction="http://tempuri.org/IEgyptianRecipesService/GetBranchesByIDResponse")]
        System.Threading.Tasks.Task<EgyptianRecipes.Entities.Branch> GetBranchesByIDAsync(long ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgyptianRecipesService/InsertNewBranch", ReplyAction="http://tempuri.org/IEgyptianRecipesService/InsertNewBranchResponse")]
        EgyptianRecipes.Web.EgyptianRecipesService.InsertNewBranchResponse InsertNewBranch(EgyptianRecipes.Web.EgyptianRecipesService.InsertNewBranchRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgyptianRecipesService/InsertNewBranch", ReplyAction="http://tempuri.org/IEgyptianRecipesService/InsertNewBranchResponse")]
        System.Threading.Tasks.Task<EgyptianRecipes.Web.EgyptianRecipesService.InsertNewBranchResponse> InsertNewBranchAsync(EgyptianRecipes.Web.EgyptianRecipesService.InsertNewBranchRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgyptianRecipesService/UpdateBranch", ReplyAction="http://tempuri.org/IEgyptianRecipesService/UpdateBranchResponse")]
        EgyptianRecipes.Web.EgyptianRecipesService.UpdateBranchResponse UpdateBranch(EgyptianRecipes.Web.EgyptianRecipesService.UpdateBranchRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgyptianRecipesService/UpdateBranch", ReplyAction="http://tempuri.org/IEgyptianRecipesService/UpdateBranchResponse")]
        System.Threading.Tasks.Task<EgyptianRecipes.Web.EgyptianRecipesService.UpdateBranchResponse> UpdateBranchAsync(EgyptianRecipes.Web.EgyptianRecipesService.UpdateBranchRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgyptianRecipesService/DeleteBranch", ReplyAction="http://tempuri.org/IEgyptianRecipesService/DeleteBranchResponse")]
        bool DeleteBranch(long ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgyptianRecipesService/DeleteBranch", ReplyAction="http://tempuri.org/IEgyptianRecipesService/DeleteBranchResponse")]
        System.Threading.Tasks.Task<bool> DeleteBranchAsync(long ID);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ValidateBranch", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ValidateBranchRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public EgyptianRecipes.Entities.Branch branch;
        
        public ValidateBranchRequest() {
        }
        
        public ValidateBranchRequest(EgyptianRecipes.Entities.Branch branch) {
            this.branch = branch;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ValidateBranchResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ValidateBranchResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool ValidateBranchResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string[] errorMessages;
        
        public ValidateBranchResponse() {
        }
        
        public ValidateBranchResponse(bool ValidateBranchResult, string[] errorMessages) {
            this.ValidateBranchResult = ValidateBranchResult;
            this.errorMessages = errorMessages;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertNewBranch", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertNewBranchRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public EgyptianRecipes.Entities.Branch branch;
        
        public InsertNewBranchRequest() {
        }
        
        public InsertNewBranchRequest(EgyptianRecipes.Entities.Branch branch) {
            this.branch = branch;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertNewBranchResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertNewBranchResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool InsertNewBranchResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string[] errorMessages;
        
        public InsertNewBranchResponse() {
        }
        
        public InsertNewBranchResponse(bool InsertNewBranchResult, string[] errorMessages) {
            this.InsertNewBranchResult = InsertNewBranchResult;
            this.errorMessages = errorMessages;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateBranch", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateBranchRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public EgyptianRecipes.Entities.Branch branch;
        
        public UpdateBranchRequest() {
        }
        
        public UpdateBranchRequest(EgyptianRecipes.Entities.Branch branch) {
            this.branch = branch;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateBranchResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateBranchResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool UpdateBranchResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string[] errorMessages;
        
        public UpdateBranchResponse() {
        }
        
        public UpdateBranchResponse(bool UpdateBranchResult, string[] errorMessages) {
            this.UpdateBranchResult = UpdateBranchResult;
            this.errorMessages = errorMessages;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEgyptianRecipesServiceChannel : EgyptianRecipes.Web.EgyptianRecipesService.IEgyptianRecipesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EgyptianRecipesServiceClient : System.ServiceModel.ClientBase<EgyptianRecipes.Web.EgyptianRecipesService.IEgyptianRecipesService>, EgyptianRecipes.Web.EgyptianRecipesService.IEgyptianRecipesService {
        
        public EgyptianRecipesServiceClient() {
        }
        
        public EgyptianRecipesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EgyptianRecipesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EgyptianRecipesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EgyptianRecipesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EgyptianRecipes.Web.EgyptianRecipesService.ValidateBranchResponse EgyptianRecipes.Web.EgyptianRecipesService.IEgyptianRecipesService.ValidateBranch(EgyptianRecipes.Web.EgyptianRecipesService.ValidateBranchRequest request) {
            return base.Channel.ValidateBranch(request);
        }
        
        public bool ValidateBranch(EgyptianRecipes.Entities.Branch branch, out string[] errorMessages) {
            EgyptianRecipes.Web.EgyptianRecipesService.ValidateBranchRequest inValue = new EgyptianRecipes.Web.EgyptianRecipesService.ValidateBranchRequest();
            inValue.branch = branch;
            EgyptianRecipes.Web.EgyptianRecipesService.ValidateBranchResponse retVal = ((EgyptianRecipes.Web.EgyptianRecipesService.IEgyptianRecipesService)(this)).ValidateBranch(inValue);
            errorMessages = retVal.errorMessages;
            return retVal.ValidateBranchResult;
        }
        
        public System.Threading.Tasks.Task<EgyptianRecipes.Web.EgyptianRecipesService.ValidateBranchResponse> ValidateBranchAsync(EgyptianRecipes.Web.EgyptianRecipesService.ValidateBranchRequest request) {
            return base.Channel.ValidateBranchAsync(request);
        }
        
        public EgyptianRecipes.Entities.Branch[] GetAllBranches() {
            return base.Channel.GetAllBranches();
        }
        
        public System.Threading.Tasks.Task<EgyptianRecipes.Entities.Branch[]> GetAllBranchesAsync() {
            return base.Channel.GetAllBranchesAsync();
        }
        
        public EgyptianRecipes.Entities.Branch GetBranchesByID(long ID) {
            return base.Channel.GetBranchesByID(ID);
        }
        
        public System.Threading.Tasks.Task<EgyptianRecipes.Entities.Branch> GetBranchesByIDAsync(long ID) {
            return base.Channel.GetBranchesByIDAsync(ID);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EgyptianRecipes.Web.EgyptianRecipesService.InsertNewBranchResponse EgyptianRecipes.Web.EgyptianRecipesService.IEgyptianRecipesService.InsertNewBranch(EgyptianRecipes.Web.EgyptianRecipesService.InsertNewBranchRequest request) {
            return base.Channel.InsertNewBranch(request);
        }
        
        public bool InsertNewBranch(EgyptianRecipes.Entities.Branch branch, out string[] errorMessages) {
            EgyptianRecipes.Web.EgyptianRecipesService.InsertNewBranchRequest inValue = new EgyptianRecipes.Web.EgyptianRecipesService.InsertNewBranchRequest();
            inValue.branch = branch;
            EgyptianRecipes.Web.EgyptianRecipesService.InsertNewBranchResponse retVal = ((EgyptianRecipes.Web.EgyptianRecipesService.IEgyptianRecipesService)(this)).InsertNewBranch(inValue);
            errorMessages = retVal.errorMessages;
            return retVal.InsertNewBranchResult;
        }
        
        public System.Threading.Tasks.Task<EgyptianRecipes.Web.EgyptianRecipesService.InsertNewBranchResponse> InsertNewBranchAsync(EgyptianRecipes.Web.EgyptianRecipesService.InsertNewBranchRequest request) {
            return base.Channel.InsertNewBranchAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EgyptianRecipes.Web.EgyptianRecipesService.UpdateBranchResponse EgyptianRecipes.Web.EgyptianRecipesService.IEgyptianRecipesService.UpdateBranch(EgyptianRecipes.Web.EgyptianRecipesService.UpdateBranchRequest request) {
            return base.Channel.UpdateBranch(request);
        }
        
        public bool UpdateBranch(EgyptianRecipes.Entities.Branch branch, out string[] errorMessages) {
            EgyptianRecipes.Web.EgyptianRecipesService.UpdateBranchRequest inValue = new EgyptianRecipes.Web.EgyptianRecipesService.UpdateBranchRequest();
            inValue.branch = branch;
            EgyptianRecipes.Web.EgyptianRecipesService.UpdateBranchResponse retVal = ((EgyptianRecipes.Web.EgyptianRecipesService.IEgyptianRecipesService)(this)).UpdateBranch(inValue);
            errorMessages = retVal.errorMessages;
            return retVal.UpdateBranchResult;
        }
        
        public System.Threading.Tasks.Task<EgyptianRecipes.Web.EgyptianRecipesService.UpdateBranchResponse> UpdateBranchAsync(EgyptianRecipes.Web.EgyptianRecipesService.UpdateBranchRequest request) {
            return base.Channel.UpdateBranchAsync(request);
        }
        
        public bool DeleteBranch(long ID) {
            return base.Channel.DeleteBranch(ID);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteBranchAsync(long ID) {
            return base.Channel.DeleteBranchAsync(ID);
        }
    }
}