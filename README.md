# MyThings Assignment

### Following steps were taken to implement the assignment

1. **Sql Server** database was spawned in Docker using the `Sql Server` docker image. 
2. The `.bacpac` file provided was loaded into the `Sql Server` database.
3. **ElasticSearch** was spawned at the default port: `http://localhost:9200` along with **Kibana** at `http://localhost:5601`.
4. Appropriate data models were created to load the data coming from `Sql Server` database.
5. A background job was implemented using `Quartz` framework to periodically run the sync job from Sql Server to ElasticSearch. This job will run every 1 hour.
6. The following endpoints were tested:
    1. `/search`: This endpoint returns a paginated list of subStores based on the following parameters: 
       1. NickName
       2. NameInEnglish
       3. NameInArabic
       4. SubStoreType.Tenant.StoreName
       
        The results are sorted by the score in descending order.
    2. `/suggestions`: This endpoint returns a paginated list of autocompletion keywords based on the user search. The following parameters are considered when generating this completion feature.
       1. Search
       2. SearchNameInEnglish
       3. SearchNameInArabic
       4. SearchNickName
    3. `/most-common-words`: A new index was created on elastic search to keep track of user searches and store them subsequently on elastic search. Once done,
        upon hitting this endpoint, the searches are aggregated based on their count, and the searches having the most count are shown.