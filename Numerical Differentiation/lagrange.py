#Lagrange Interpolation- Differentiation

#Inputs: xi list, f(x)=yi list and point p for which o/p is to be found
def lagrange(x,y,p):

    n=len(x)
    temp1=1
    temp2=1
    l=[]
    for i in range(0,n):
        temp1=1
        temp2=1
        for j in range(0,n):
            if i!=j:
                temp1*=(p-x[j])
                temp2*=(x[i]-x[j])
                #print('x[j]:',x[j])
        #print(temp1,temp2)
        l.append(temp1/temp2*y[i])

    sum=0
    for i in range(0,len(l)):
        sum+=l[i]

    print('For x=',p,'value of f(x) is=',sum)


lagrange([1,2,3,5],[1,4,9,25],4)
    
'''
OUTPUT:
For x= 4 value of f(x) is= 16.0
'''
