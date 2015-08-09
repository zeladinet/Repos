SELECT vwRequestAnswerS.REQUEST_ID

,[Status]
,MAX(ModifiedDate)	 AS 'Last Change Date'
, qUESTION_ID	
,ANSWER
,QUESTION



FROM vwRequestAnswerS JOIN vwRequests ON vwRequestAnswerS.Request_ID = vwRequests.Request_ID


WHERE 
Question_ID = 91 AND ANSWER = 'No'
and ModifiedDate > dateadd(day, -60, getdate())


GROUP BY ModifiedDate, vwRequestAnswerS.request_id, Status, Question_ID, Answer, Question