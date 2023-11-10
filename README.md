# GymRivkiToledano
רבקי טולידאנו – RestFuiIl API
תיאור פרויקט:
מערכת לניהול  חדר כושר במערכת זאת יהיה תטפל בציוד כושר, חברי חדר כושר, שעורי כושר שמציע המרכז.
ישויות:
ציוד
חברים
שיעורים
מיפוי Routes לציוד:
שליפת רשימת הציוד    
https://gym.co.il/api/equipment
שליפת נתון ציוד לפי מזהה     
https://gym.co.il/api/equipment/{equipmentId}
                                           
הוספת ציוד חדש
https://gym.co.il/api/equipment/add

עדכון פרטי ציוד
https://gym.co.il/api/equipment/{equipmentId}/update

הוצאת ציוד מהמרכז
https://gym.co.il/api/equipment/{equipmentId}/remove


מיפוי Routes לחברים:
שליפת רשימת חברים
https://gym.co.il/api/members

שליפת חבר לפי מזהה
https://gym.co.il/api/members/{memberId}

רישום (הוספה) חבר חדש
https://gym.co.il/api/members/register

עדכון פרטי חבר
https://gym.co.il/api/members/{memberId}/update

ביטול (מחיקה) פרטי חבר
https://gym.co.il/api/members/{memberId}/deactivate


מיפוי Routes שיעורים:
שליפת רשימת השיעורים
https://gyms.co.il/api/classes

שליפת שיעור לפי מזהה
https://gyms.co.il/api/classes/{classId}

הוספת שיעור חדש
https://gyms.co.il/api/classes/create

עדכון פרטי שיעור
https://gyms.co.il/api/classes/{classId}/update

הסרת שיעור
https://gyms.co.il/api/classes/{classId}/remove


