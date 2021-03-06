﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shared.Entities
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Shared.Entities")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Shared.Entities.FullTimeEmployee))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Shared.Entities.PartTimeEmployee))]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private string NameField;
        
        private System.DateTime StartDateField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate
        {
            get
            {
                return this.StartDateField;
            }
            set
            {
                this.StartDateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FullTimeEmployee", Namespace="http://schemas.datacontract.org/2004/07/Shared.Entities")]
    public partial class FullTimeEmployee : Shared.Entities.Employee
    {
        
        private int SalaryField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Salary
        {
            get
            {
                return this.SalaryField;
            }
            set
            {
                this.SalaryField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PartTimeEmployee", Namespace="http://schemas.datacontract.org/2004/07/Shared.Entities")]
    public partial class PartTimeEmployee : Shared.Entities.Employee
    {
        
        private double HourlyRateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double HourlyRate
        {
            get
            {
                return this.HourlyRateField;
            }
            set
            {
                this.HourlyRateField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:8834/tsi1/", ConfigurationName="IServiceEmployees")]
public interface IServiceEmployees
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8834/tsi1/IServiceEmployees/AddEmployee", ReplyAction="http://localhost:8834/tsi1/IServiceEmployees/AddEmployeeResponse")]
    void AddEmployee(Shared.Entities.Employee emp);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8834/tsi1/IServiceEmployees/AddEmployee", ReplyAction="http://localhost:8834/tsi1/IServiceEmployees/AddEmployeeResponse")]
    System.Threading.Tasks.Task AddEmployeeAsync(Shared.Entities.Employee emp);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8834/tsi1/IServiceEmployees/DeleteEmployee", ReplyAction="http://localhost:8834/tsi1/IServiceEmployees/DeleteEmployeeResponse")]
    void DeleteEmployee(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8834/tsi1/IServiceEmployees/DeleteEmployee", ReplyAction="http://localhost:8834/tsi1/IServiceEmployees/DeleteEmployeeResponse")]
    System.Threading.Tasks.Task DeleteEmployeeAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8834/tsi1/IServiceEmployees/UpdateEmployee", ReplyAction="http://localhost:8834/tsi1/IServiceEmployees/UpdateEmployeeResponse")]
    void UpdateEmployee(Shared.Entities.Employee emp);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8834/tsi1/IServiceEmployees/UpdateEmployee", ReplyAction="http://localhost:8834/tsi1/IServiceEmployees/UpdateEmployeeResponse")]
    System.Threading.Tasks.Task UpdateEmployeeAsync(Shared.Entities.Employee emp);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8834/tsi1/IServiceEmployees/GetAllEmployees", ReplyAction="http://localhost:8834/tsi1/IServiceEmployees/GetAllEmployeesResponse")]
    Shared.Entities.Employee[] GetAllEmployees();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8834/tsi1/IServiceEmployees/GetAllEmployees", ReplyAction="http://localhost:8834/tsi1/IServiceEmployees/GetAllEmployeesResponse")]
    System.Threading.Tasks.Task<Shared.Entities.Employee[]> GetAllEmployeesAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8834/tsi1/IServiceEmployees/GetEmployee", ReplyAction="http://localhost:8834/tsi1/IServiceEmployees/GetEmployeeResponse")]
    Shared.Entities.Employee GetEmployee(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8834/tsi1/IServiceEmployees/GetEmployee", ReplyAction="http://localhost:8834/tsi1/IServiceEmployees/GetEmployeeResponse")]
    System.Threading.Tasks.Task<Shared.Entities.Employee> GetEmployeeAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8834/tsi1/IServiceEmployees/CalcPartTimeEmployeeSalary", ReplyAction="http://localhost:8834/tsi1/IServiceEmployees/CalcPartTimeEmployeeSalaryResponse")]
    double CalcPartTimeEmployeeSalary(int idEmployee, int hours);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8834/tsi1/IServiceEmployees/CalcPartTimeEmployeeSalary", ReplyAction="http://localhost:8834/tsi1/IServiceEmployees/CalcPartTimeEmployeeSalaryResponse")]
    System.Threading.Tasks.Task<double> CalcPartTimeEmployeeSalaryAsync(int idEmployee, int hours);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServiceEmployeesChannel : IServiceEmployees, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ServiceEmployeesClient : System.ServiceModel.ClientBase<IServiceEmployees>, IServiceEmployees
{
    
    public ServiceEmployeesClient()
    {
    }
    
    public ServiceEmployeesClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ServiceEmployeesClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceEmployeesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceEmployeesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void AddEmployee(Shared.Entities.Employee emp)
    {
        base.Channel.AddEmployee(emp);
    }
    
    public System.Threading.Tasks.Task AddEmployeeAsync(Shared.Entities.Employee emp)
    {
        return base.Channel.AddEmployeeAsync(emp);
    }
    
    public void DeleteEmployee(int id)
    {
        base.Channel.DeleteEmployee(id);
    }
    
    public System.Threading.Tasks.Task DeleteEmployeeAsync(int id)
    {
        return base.Channel.DeleteEmployeeAsync(id);
    }
    
    public void UpdateEmployee(Shared.Entities.Employee emp)
    {
        base.Channel.UpdateEmployee(emp);
    }
    
    public System.Threading.Tasks.Task UpdateEmployeeAsync(Shared.Entities.Employee emp)
    {
        return base.Channel.UpdateEmployeeAsync(emp);
    }
    
    public Shared.Entities.Employee[] GetAllEmployees()
    {
        return base.Channel.GetAllEmployees();
    }
    
    public System.Threading.Tasks.Task<Shared.Entities.Employee[]> GetAllEmployeesAsync()
    {
        return base.Channel.GetAllEmployeesAsync();
    }
    
    public Shared.Entities.Employee GetEmployee(int id)
    {
        return base.Channel.GetEmployee(id);
    }
    
    public System.Threading.Tasks.Task<Shared.Entities.Employee> GetEmployeeAsync(int id)
    {
        return base.Channel.GetEmployeeAsync(id);
    }
    
    public double CalcPartTimeEmployeeSalary(int idEmployee, int hours)
    {
        return base.Channel.CalcPartTimeEmployeeSalary(idEmployee, hours);
    }
    
    public System.Threading.Tasks.Task<double> CalcPartTimeEmployeeSalaryAsync(int idEmployee, int hours)
    {
        return base.Channel.CalcPartTimeEmployeeSalaryAsync(idEmployee, hours);
    }
}
