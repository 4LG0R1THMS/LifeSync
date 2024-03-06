variable "resource_group_name" {
  type        = string
  description = "Name of the resource group"
}

variable "resource_group_location" {
  type        = string
  description = "Location of the resource group"
}

variable "app_service_plan_name" {
  type        = string
  description = "Name of the app service"
}

variable "app_service_name" {
  type        = string
  description = "Name of the app"
}

variable "sql_server_name" {
  type        = string
  description = "Name of the SQL server"
}

variable "sql_database_name" {
  type        = string
  description = "Name of the database"
}

variable "sql_admin_login" {
  type        = string
  description = "SQL username"
}

variable "sql_admin_password" {
  type        = string
  description = "SQL password"
}

variable "firewall_rule_name" {
  type        = string
  description = "Name of the firewall"
}

variable "repo_URL" {
  type        = string
  description = "Location of the repo"
}