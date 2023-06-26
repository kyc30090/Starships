import axios, { AxiosError, AxiosResponse } from "axios";
import { PaginatedResponse } from "../models/pagination";

const sleep = () => new Promise(resolve => setTimeout(resolve, 500))

axios.defaults.baseURL = "http://localhost:5293/api/";

const responseBody = (response: AxiosResponse) => response.data;

axios.interceptors.response.use(async response => {
    if (process.env.NODE_ENV === 'development') await sleep();
    const pagination = response.headers['pagination'];
    if (pagination) {
        response.data = new PaginatedResponse(response.data?.results, JSON.parse(pagination));
        return response;
    }
    return response;
}, (error: AxiosError) => {
    console.log(error.response);
})

function createFormData(item: any) {
    let formData = new FormData();
    for (const key in item) {
        formData.append(key, item[key])
    }
    return formData;
}

const requests = {
    get: (url: string, params?: URLSearchParams) => axios.get(url, {params}).then(responseBody),
    post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
    put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
    delete: (url: string) => axios.delete(url).then(responseBody),
    postForm: (url: string, data: FormData) => axios.post(url, data, {
        headers: {'Content-type': 'multipart/form-data'}
    }).then(responseBody),
    putForm: (url: string, data: FormData) => axios.put(url, data, {
        headers: {'Content-type': 'multipart/form-data'}
    }).then(responseBody)
}

const Starships = {
    list: (params: URLSearchParams) => requests.get('starships/list', params),
    details: (id: number) => requests.get(`starships/${id}`),
    random: () => requests.get('starships/random'),
    create: (values: any) => requests.postForm('starships', createFormData(values)),
    //create: (values: any) => requests.post('starships', values),
    update: (values: any) => requests.putForm('starships', createFormData(values)),
    delete: (id: number) => requests.delete(`starships/${id}`),
    fetchFilters: () => requests.get('starships/filters')
}

const Films = {
    list: () => requests.get('films')
}

const People = {
    list: () => requests.get('people')
}

const agent = {
    Starships,
    Films,
    People
}

export default agent;