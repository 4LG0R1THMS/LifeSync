# LifeSync Web Application Deployment Guide

This guide will walk you through the steps to deploy the LifeSync web application to Azure using Terraform. LifeSync is a `.NET` web application designed to help users organize their personal tasks and schedules.

## Prerequisites
Before proceeding with the deployment, make sure you have the following:

- `Azure account` with the necessary permissions to create resources
- `Azure CLI` installed on your local machine
- `Terraform` installed on your local machine
- `Git` installed on your local machine

## Step 1: Clone the Repository

First, clone the LifeSync repository from GitHub:

```bash
git clone https://github.com/4LG0R1THMS/personal_organizer
cd personal_organizer
```

## Step 2: Configure Terraform

Change the contents in the file named `terraform.tfvars` located in the `personal_organizer/.terraform` directory, so it suits your needs. Use the following variables to configure the file:

```hcl
resource_group_name     = "LifeSync"
resource_group_location = "West Europe"
app_service_plan_name   = "LifeSyncSP"
app_service_name        = "LifeSyncWebApp"
sql_server_name         = "LifeSyncSQLServer"
sql_database_name       = "LifeSyncDB"
sql_admin_login         = "4dm1n157r470r"
sql_admin_password      = "4-v3ry-53cr37-p455w0rd"
firewall_rule_name      = "LifeSyncFirewallRule"
repo_URL                = "https://github.com/4LG0R1THMS/personal_organizer"
```

## Step 3: Initialize Terraform

Initialize Terraform in the `personal_organizer/.terraform` directory:

```bash
terraform init
```

## Step 4: Deploy Infrastructure

Run the following command to plan the deployment:

```bash
terraform plan
```

Review the plan to ensure everything looks correct. Then, apply the Terraform configuration to deploy the resources:

```bash
terraform apply
```

Enter `yes` when prompted to confirm the deployment.

## Step 5: Accessing the Web Application

Once the deployment is complete, you can access the LifeSync web application using the following URL:

```
https://<app_service_name>.azurewebsites.net
```

Replace `<app_service_name>` with the name of your `app_service_name` defined in the `terraform.tfvars` file.

## Step 6: Cleaning Up (Optional)

If you no longer need the resources for the deployment and want to clean up, you can run the following command:

```bash
terraform destroy
```

Enter `yes` when prompted to confirm the destruction of resources.

## Conclusion

Congratulations! You have successfully deployed the `LifeSync` web application to Azure using Terraform. You can now use the application to organize your personal tasks and schedules.

For more information on Terraform and Azure, refer to the official documentation:

- [Terraform Documentation](https://www.terraform.io/docs/index.html)
- [Azure Terraform Provider Documentation](https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs)