#Date to Day Conversion
#reference- https://www.quora.com/How-does-Tomohiko-Sakamotos-Algorithm-work
import math

'''
def zellers_rule(day,month,year):

    days=['Sunday','Monday','Tuesday','Wednesday','Thursday','Friday','Saturday']

    if month>2:
        month-=2
    else:
        month+=10
        
    #print(month)
    yr=str(year)
    c=int(yr[0:2])         #getting first two digits of the year
    #print(d)
    d=year%100
    if month<=2:
        d=d-1
    print(d)
    f= day+((13*(month-1))/5)+d +math.floor(d/4)+math.floor(c/4)-(2*c)
    print(f)
    ind=int(f%7)
    print(days[ind])
    
'''

def tomohiko_sakamotos(day,month,year):

    days=['Sunday','Monday','Tuesday','Wednesday','Thursday','Friday','Saturday']
    t=[0,3,2,5,0,3,5,1,4,6,2,4]

    if month<3:
        year-=1
    d= (year+ (year//4)-(year//100)+(year//400)+t[month-1]+day)%7
    print('The day on',day,'-',month,'-',year,'is ',days[d])


#zellers_rule(12,3,1210)
tomohiko_sakamotos(29,1,2064)
