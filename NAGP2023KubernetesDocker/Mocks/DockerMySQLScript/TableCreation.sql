CREATE TABLE nagp.sessiondetails (
  Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY ,
  SessionName VARCHAR(200) ,
  SessionNumber INT ,
  SessionDate DATETIME ,
  SessionDescription VARCHAR(200) 
  );
  
INSERT INTO nagp.sessiondetails (SessionName, SessionNumber, SessionDate, SessionDescription) VALUES ('NodeJS & Chatbot', '1', '2323-01-16', 'Built Chatbot using NodeJS');
INSERT INTO nagp.sessiondetails (SessionName, SessionNumber, SessionDate, SessionDescription) VALUES ('NodeJS & Chatbot', '2', '2323-01-23', 'Built Chatbot using NodeJS');
INSERT INTO nagp.sessiondetails (SessionName, SessionNumber, SessionDate, SessionDescription) VALUES ('NodeJS & Chatbot', '3', '2323-01-30', 'Built Chatbot using NodeJS');
