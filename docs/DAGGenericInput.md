
# QueenbeeSDK.Model.DAGGenericInput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Input name. | 
**Annotations** | **Dictionary&lt;string, string&gt;** | An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries. | [optional] 
**Description** | **string** | Optional description for input. | [optional] 
**Default** | **string** | Place-holder. Overwrite this! | [optional] 
**Spec** | **Object** | An optional JSON Schema specification to validate the input value. You can use validate_spec method to validate a value against the spec. | [optional] 
**Alias** | [**List&lt;AnyOfDAGGenericInputAliasDAGStringInputAliasDAGIntegerInputAliasDAGNumberInputAliasDAGBooleanInputAliasDAGFolderInputAliasDAGFileInputAliasDAGPathInputAliasDAGArrayInputAliasDAGObjectInputAlias&gt;**](AnyOfDAGGenericInputAliasDAGStringInputAliasDAGIntegerInputAliasDAGNumberInputAliasDAGBooleanInputAliasDAGFolderInputAliasDAGFileInputAliasDAGPathInputAliasDAGArrayInputAliasDAGObjectInputAlias.md) | A list of aliases for this input in different platforms. | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "DAGGenericInput"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
