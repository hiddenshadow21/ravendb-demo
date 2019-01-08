type Basic = "DEMO_TheDocumentStore" |
             "DEMO_TheSession"       | 
             "DEMO_CreateDocument"   |
             "DEMO_EditDocument"     |
             "DEMO_DeleteDocument";

type Attachments = "DEMO_StoreAttachment";

type Revisions = "DEMO_EnableRevisions";

type Queries = "DEMO_QueryOverview"                      | 
               "DEMO_FullCollectionQuery"                |
               "DEMO_QueryByDocumentId"                  |
               "DEMO_FilteringResultsBasics"             |
               "DEMO_FilteringResultsMultipleConditions" |
               "DEMO_ProjectingIndividualFields"         |
               "DEMO_ProjectingUsingFunctions";

type StaticIndexes = "DEMO_StaticIndexesOverview" |
                     "DEMO_MapIndex"              |
                     "DEMO_MapReduceIndex";

type AutoIndexes = "DEMO_AutoMapIndex1" |
                   "DEMO_AutoMapIndex2";

type TextSearch = "DEMO_FTSWithStaticIndexSingleField" |
                  "DEMO_FTSWithStaticIndexMultipleFields"; 

type Advanced = "DEMO_ReplicationFailover" |
                "DEMO_CreateDatabase";

export type DemoType = Basic         |
                       Attachments   |
                       Revisions     |
                       Queries       |
                       StaticIndexes |
                       AutoIndexes   |
                       TextSearch    |
                       Advanced;
