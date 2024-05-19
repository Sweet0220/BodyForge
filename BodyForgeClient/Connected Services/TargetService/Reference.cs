﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BodyForgeClient.TargetService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Target", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Target : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long idField;
        
        private long id_muscleField;
        
        private long id_exerciseField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long id_muscle {
            get {
                return this.id_muscleField;
            }
            set {
                if ((this.id_muscleField.Equals(value) != true)) {
                    this.id_muscleField = value;
                    this.RaisePropertyChanged("id_muscle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public long id_exercise {
            get {
                return this.id_exerciseField;
            }
            set {
                if ((this.id_exerciseField.Equals(value) != true)) {
                    this.id_exerciseField = value;
                    this.RaisePropertyChanged("id_exercise");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TargetService.TargetWebServiceSoap")]
    public interface TargetWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name getByIdResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getById", ReplyAction="*")]
        BodyForgeClient.TargetService.getByIdResponse getById(BodyForgeClient.TargetService.getByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getById", ReplyAction="*")]
        System.Threading.Tasks.Task<BodyForgeClient.TargetService.getByIdResponse> getByIdAsync(BodyForgeClient.TargetService.getByIdRequest request);
        
        // CODEGEN: Generating message contract since element name getByExerciseIdResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getByExerciseId", ReplyAction="*")]
        BodyForgeClient.TargetService.getByExerciseIdResponse getByExerciseId(BodyForgeClient.TargetService.getByExerciseIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getByExerciseId", ReplyAction="*")]
        System.Threading.Tasks.Task<BodyForgeClient.TargetService.getByExerciseIdResponse> getByExerciseIdAsync(BodyForgeClient.TargetService.getByExerciseIdRequest request);
        
        // CODEGEN: Generating message contract since element name getByMuscleIdResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getByMuscleId", ReplyAction="*")]
        BodyForgeClient.TargetService.getByMuscleIdResponse getByMuscleId(BodyForgeClient.TargetService.getByMuscleIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getByMuscleId", ReplyAction="*")]
        System.Threading.Tasks.Task<BodyForgeClient.TargetService.getByMuscleIdResponse> getByMuscleIdAsync(BodyForgeClient.TargetService.getByMuscleIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getById", Namespace="http://tempuri.org/", Order=0)]
        public BodyForgeClient.TargetService.getByIdRequestBody Body;
        
        public getByIdRequest() {
        }
        
        public getByIdRequest(BodyForgeClient.TargetService.getByIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getByIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long id;
        
        public getByIdRequestBody() {
        }
        
        public getByIdRequestBody(long id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getByIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public BodyForgeClient.TargetService.getByIdResponseBody Body;
        
        public getByIdResponse() {
        }
        
        public getByIdResponse(BodyForgeClient.TargetService.getByIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getByIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BodyForgeClient.TargetService.Target getByIdResult;
        
        public getByIdResponseBody() {
        }
        
        public getByIdResponseBody(BodyForgeClient.TargetService.Target getByIdResult) {
            this.getByIdResult = getByIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getByExerciseIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getByExerciseId", Namespace="http://tempuri.org/", Order=0)]
        public BodyForgeClient.TargetService.getByExerciseIdRequestBody Body;
        
        public getByExerciseIdRequest() {
        }
        
        public getByExerciseIdRequest(BodyForgeClient.TargetService.getByExerciseIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getByExerciseIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long exerciseId;
        
        public getByExerciseIdRequestBody() {
        }
        
        public getByExerciseIdRequestBody(long exerciseId) {
            this.exerciseId = exerciseId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getByExerciseIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getByExerciseIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public BodyForgeClient.TargetService.getByExerciseIdResponseBody Body;
        
        public getByExerciseIdResponse() {
        }
        
        public getByExerciseIdResponse(BodyForgeClient.TargetService.getByExerciseIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getByExerciseIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BodyForgeClient.TargetService.Target[] getByExerciseIdResult;
        
        public getByExerciseIdResponseBody() {
        }
        
        public getByExerciseIdResponseBody(BodyForgeClient.TargetService.Target[] getByExerciseIdResult) {
            this.getByExerciseIdResult = getByExerciseIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getByMuscleIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getByMuscleId", Namespace="http://tempuri.org/", Order=0)]
        public BodyForgeClient.TargetService.getByMuscleIdRequestBody Body;
        
        public getByMuscleIdRequest() {
        }
        
        public getByMuscleIdRequest(BodyForgeClient.TargetService.getByMuscleIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getByMuscleIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long muscleId;
        
        public getByMuscleIdRequestBody() {
        }
        
        public getByMuscleIdRequestBody(long muscleId) {
            this.muscleId = muscleId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getByMuscleIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getByMuscleIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public BodyForgeClient.TargetService.getByMuscleIdResponseBody Body;
        
        public getByMuscleIdResponse() {
        }
        
        public getByMuscleIdResponse(BodyForgeClient.TargetService.getByMuscleIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getByMuscleIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BodyForgeClient.TargetService.Target[] getByMuscleIdResult;
        
        public getByMuscleIdResponseBody() {
        }
        
        public getByMuscleIdResponseBody(BodyForgeClient.TargetService.Target[] getByMuscleIdResult) {
            this.getByMuscleIdResult = getByMuscleIdResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TargetWebServiceSoapChannel : BodyForgeClient.TargetService.TargetWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TargetWebServiceSoapClient : System.ServiceModel.ClientBase<BodyForgeClient.TargetService.TargetWebServiceSoap>, BodyForgeClient.TargetService.TargetWebServiceSoap {
        
        public TargetWebServiceSoapClient() {
        }
        
        public TargetWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TargetWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TargetWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TargetWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BodyForgeClient.TargetService.getByIdResponse BodyForgeClient.TargetService.TargetWebServiceSoap.getById(BodyForgeClient.TargetService.getByIdRequest request) {
            return base.Channel.getById(request);
        }
        
        public BodyForgeClient.TargetService.Target getById(long id) {
            BodyForgeClient.TargetService.getByIdRequest inValue = new BodyForgeClient.TargetService.getByIdRequest();
            inValue.Body = new BodyForgeClient.TargetService.getByIdRequestBody();
            inValue.Body.id = id;
            BodyForgeClient.TargetService.getByIdResponse retVal = ((BodyForgeClient.TargetService.TargetWebServiceSoap)(this)).getById(inValue);
            return retVal.Body.getByIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BodyForgeClient.TargetService.getByIdResponse> BodyForgeClient.TargetService.TargetWebServiceSoap.getByIdAsync(BodyForgeClient.TargetService.getByIdRequest request) {
            return base.Channel.getByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<BodyForgeClient.TargetService.getByIdResponse> getByIdAsync(long id) {
            BodyForgeClient.TargetService.getByIdRequest inValue = new BodyForgeClient.TargetService.getByIdRequest();
            inValue.Body = new BodyForgeClient.TargetService.getByIdRequestBody();
            inValue.Body.id = id;
            return ((BodyForgeClient.TargetService.TargetWebServiceSoap)(this)).getByIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BodyForgeClient.TargetService.getByExerciseIdResponse BodyForgeClient.TargetService.TargetWebServiceSoap.getByExerciseId(BodyForgeClient.TargetService.getByExerciseIdRequest request) {
            return base.Channel.getByExerciseId(request);
        }
        
        public BodyForgeClient.TargetService.Target[] getByExerciseId(long exerciseId) {
            BodyForgeClient.TargetService.getByExerciseIdRequest inValue = new BodyForgeClient.TargetService.getByExerciseIdRequest();
            inValue.Body = new BodyForgeClient.TargetService.getByExerciseIdRequestBody();
            inValue.Body.exerciseId = exerciseId;
            BodyForgeClient.TargetService.getByExerciseIdResponse retVal = ((BodyForgeClient.TargetService.TargetWebServiceSoap)(this)).getByExerciseId(inValue);
            return retVal.Body.getByExerciseIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BodyForgeClient.TargetService.getByExerciseIdResponse> BodyForgeClient.TargetService.TargetWebServiceSoap.getByExerciseIdAsync(BodyForgeClient.TargetService.getByExerciseIdRequest request) {
            return base.Channel.getByExerciseIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<BodyForgeClient.TargetService.getByExerciseIdResponse> getByExerciseIdAsync(long exerciseId) {
            BodyForgeClient.TargetService.getByExerciseIdRequest inValue = new BodyForgeClient.TargetService.getByExerciseIdRequest();
            inValue.Body = new BodyForgeClient.TargetService.getByExerciseIdRequestBody();
            inValue.Body.exerciseId = exerciseId;
            return ((BodyForgeClient.TargetService.TargetWebServiceSoap)(this)).getByExerciseIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BodyForgeClient.TargetService.getByMuscleIdResponse BodyForgeClient.TargetService.TargetWebServiceSoap.getByMuscleId(BodyForgeClient.TargetService.getByMuscleIdRequest request) {
            return base.Channel.getByMuscleId(request);
        }
        
        public BodyForgeClient.TargetService.Target[] getByMuscleId(long muscleId) {
            BodyForgeClient.TargetService.getByMuscleIdRequest inValue = new BodyForgeClient.TargetService.getByMuscleIdRequest();
            inValue.Body = new BodyForgeClient.TargetService.getByMuscleIdRequestBody();
            inValue.Body.muscleId = muscleId;
            BodyForgeClient.TargetService.getByMuscleIdResponse retVal = ((BodyForgeClient.TargetService.TargetWebServiceSoap)(this)).getByMuscleId(inValue);
            return retVal.Body.getByMuscleIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BodyForgeClient.TargetService.getByMuscleIdResponse> BodyForgeClient.TargetService.TargetWebServiceSoap.getByMuscleIdAsync(BodyForgeClient.TargetService.getByMuscleIdRequest request) {
            return base.Channel.getByMuscleIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<BodyForgeClient.TargetService.getByMuscleIdResponse> getByMuscleIdAsync(long muscleId) {
            BodyForgeClient.TargetService.getByMuscleIdRequest inValue = new BodyForgeClient.TargetService.getByMuscleIdRequest();
            inValue.Body = new BodyForgeClient.TargetService.getByMuscleIdRequestBody();
            inValue.Body.muscleId = muscleId;
            return ((BodyForgeClient.TargetService.TargetWebServiceSoap)(this)).getByMuscleIdAsync(inValue);
        }
    }
}