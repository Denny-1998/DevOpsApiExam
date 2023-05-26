import http from 'k6/http';
import { check } from 'k6';

export let options = {
    vus: 10, // Number of virtual users
    duration: '30s', // Duration of the test
};

export default function () {
    const url = 'http://localhost:7077/about';

    const payload = JSON.stringify({
        sender: 'test@example.com',
        subject: 'Test Subject',
        message: 'Test Message',
    });

    const params = {
        headers: {
            'Content-Type': 'application/json',
        },
    };

    const response = http.post(url, payload, params);

    check(response, {
        'Status is 200': (r) => r.status === 200,
        'Response contains expected data': (r) => r.body.includes('expected data'),
    });
}
